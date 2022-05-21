using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Device.Location;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace Yazlab_Proje_1_1
{
  
    public partial class formAnaEkran : Form
    {
       
        public formAnaEkran()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        SqlConnection baglanti = new SqlConnection("[Veritabanı-Bağlantı-Stringi-Yazın]");
        int kullaniciId;
        PointLatLng kargoBayiKonumu;
        PointLatLng kargocuAnlikKonum;
        List<List<string>> musteriler;
        List<List<string>> dagitilacakKargolar;
        PointLatLng[] dagitilacakLokasyonlar;
        Thread kargoDagitim;
        // Djisktra

        void printSolution(double[] dist, int V)
        {
            Console.Write("Vertex     Distance from Source\n");
            for (int i = 0; i < V; i++)
                Console.Write(i + " \t\t " + dist[i] + "\n");
        }

        int minDistance(double[] dist,bool[] sptSet,int V)
        {
            double min = int.MaxValue;
            int min_index = -1;

            for (int v = 0; v < V; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }
        double[] dijkstra(double[,] graph, int src, int V)
        {
            double[] dist = new double[V];
            bool[] sptSet = new bool[V];

            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            dist[src] = 0;

            for (int count = 0; count < V - 1; count++)
            {
                int u = minDistance(dist, sptSet,V);
                sptSet[u] = true;
                for (int v = 0; v < V; v++)
                    if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                        dist[v] = dist[u] + graph[u, v];
            }

            printSolution(dist, V);
            return dist;
        }

        void teslimatSirasiHesaplaVeCizdir()
        {
            while (true)
            {
                try
                {
                    //Teslim edilecek tüm kargoları çek
                    gMapControlHarita.Position = kargocuAnlikKonum;
                    baglanti.Open();
                    SqlCommand dagitilacakKargolarCmd = new SqlCommand("SELECT * FROM Kargolar WHERE kargoDurumu=0 OR kargoDurumu=1", baglanti);
                    SqlDataReader drDagitilacakKargolar = dagitilacakKargolarCmd.ExecuteReader();
                    dagitilacakKargolar = new List<List<string>>();
                    dagitilacakKargolar.Clear();
                    while (drDagitilacakKargolar.Read())
                    {
                        //Kayit
                        List<string> kayit = new List<string>();
                        kayit.Add(drDagitilacakKargolar[0].ToString());
                        kayit.Add(drDagitilacakKargolar[1].ToString());
                        kayit.Add(drDagitilacakKargolar[2].ToString());

                        //Kayiti diziye ekle
                        dagitilacakKargolar.Add(kayit);
                    }

                    drDagitilacakKargolar.Close();
                    if (dagitilacakKargolar.Count != 0)
                    {
                        //Dağıtılacak tüm kargoların konumları diziye al
                        dagitilacakLokasyonlar = new PointLatLng[dagitilacakKargolar.Count + 1];

                        for (int i = 0; i < dagitilacakKargolar.Count + 1; i++)
                        {
                            for (int j = 0; j < musteriler.Count; j++)
                            {
                                if (i == 0)
                                {
                                    dagitilacakLokasyonlar[i] = kargocuAnlikKonum;
                                    break;
                                }
                                else if (i != 0 && musteriler[j][0].Equals(dagitilacakKargolar[i - 1][1]))
                                {
                                    dagitilacakLokasyonlar[i] = new PointLatLng(Convert.ToDouble(musteriler[j][2]), Convert.ToDouble(musteriler[j][3]));
                                    break;
                                }
                            }

                        }

                        // Tüm konumların birbirine olan uzaklıklarını grafa cevir
                        double[,] mesafeler = new double[dagitilacakLokasyonlar.Length, dagitilacakLokasyonlar.Length];
                        for (int i = 0; i < dagitilacakLokasyonlar.Length; i++)
                        {
                            for (int j = 0; j < dagitilacakLokasyonlar.Length; j++)
                            {
                                mesafeler[i, j] = GoogleMapProvider.Instance.GetRoute(dagitilacakLokasyonlar[i], dagitilacakLokasyonlar[j], true, true, Convert.ToInt32(gMapControlHarita.Zoom)).Distance;
                                Console.WriteLine(i.ToString() + " 'den " + j.ToString() + " 'ye olan mesafe: " + mesafeler[i, j].ToString());
                            }
                        }
                        double[] enKisaYol = dijkstra(mesafeler, 0, dagitilacakLokasyonlar.Length);
                        //Konumları sırala (Bubble Sort)
                        for (int i = 0; i <= enKisaYol.Length - 1; i++)
                        {
                            for (int j = 1; j <= enKisaYol.Length - 1; j++)
                            {
                                if (enKisaYol[j - 1] > enKisaYol[j])
                                {
                                    double gecici;
                                    gecici = enKisaYol[j - 1];
                                    enKisaYol[j - 1] = enKisaYol[j];
                                    enKisaYol[j] = gecici;

                                    PointLatLng geciciKonum;
                                    geciciKonum = dagitilacakLokasyonlar[j - 1];
                                    dagitilacakLokasyonlar[j - 1] = dagitilacakLokasyonlar[j];
                                    dagitilacakLokasyonlar[j] = geciciKonum;

                                }
                            }
                        }

                        // Konumları harita üzerinde cizdir.
                        gMapControlHarita.Overlays.Clear();
                        GMapOverlay tumRota = new GMapOverlay("tumRota");
                        GMapOverlay markers = new GMapOverlay("markers");
                        GMapMarker kargocu = new GMarkerGoogle(kargocuAnlikKonum, GMarkerGoogleType.green_big_go);
                        markers.Markers.Add(kargocu);
                        for (int i = 1; i < dagitilacakLokasyonlar.Length; i++)
                        {
                            GMapMarker marker = new GMarkerGoogle(dagitilacakLokasyonlar[i], GMarkerGoogleType.blue_pushpin);
                            MapRoute rota = GoogleMapProvider.Instance.GetRoute(dagitilacakLokasyonlar[i - 1], dagitilacakLokasyonlar[i], true, true, Convert.ToInt32(gMapControlHarita.Zoom));
                            GMapRoute r = new GMapRoute(rota.Points, "Rotam")
                            {
                                Stroke = new Pen(Color.FromArgb(150, 0, 255, 0), 5)
                            };
                            markers.Markers.Add(marker);
                            tumRota.Routes.Add(r);
                        }
                        gMapControlHarita.Overlays.Add(tumRota);
                        gMapControlHarita.Overlays.Add(markers);

                        // kargocuyu Hareket ettir
                        if (kargocuAnlikKonum != kargoBayiKonumu)
                        {
                            for (int i = 0; i < musteriler.Count; i++)
                            {
                                PointLatLng musteriKonum = new PointLatLng(Convert.ToDouble(musteriler[i][2]), Convert.ToDouble(musteriler[i][3]));
                                //kargocu teslim etti
                                if (kargocuAnlikKonum == musteriKonum)
                                {
                                    SqlCommand kargoTeslimCmd = new SqlCommand("UPDATE Kargolar SET kargoDurumu=2 WHERE musteriId=" + musteriler[i][0] + "", baglanti);
                                    kargoTeslimCmd.ExecuteNonQuery();
                                    break;
                                }
                                else if (dagitilacakLokasyonlar[1] == musteriKonum)
                                {
                                    SqlCommand kargoTeslimEdilecekCmd = new SqlCommand("UPDATE Kargolar SET kargoDurumu=1 WHERE musteriId=" + musteriler[i][0] + "", baglanti);
                                    kargoTeslimEdilecekCmd.ExecuteNonQuery();
                                }
                            }
                        }
                        kargocuAnlikKonum = dagitilacakLokasyonlar[1];

                        baglanti.Close();
                        teslimatDurumEkraniGüncelle();
                        gMapControlHarita.Zoom = 11;
                        gMapControlHarita.Zoom = gMapControlHarita.Zoom + 1;
                        Thread.Sleep(10000);
                    }
                    else
                    {
                        MessageBox.Show("Tüm Kargolar Dağıtıldı.");
                        baglanti.Close();
                        buttonKullaniciCikis.Enabled = true;
                        break;
                    }

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglanti.Close();
                }
            }
        }

        async void apiIslemleri(int islemTuru, string[] dizi)
        {

            try
            {
                string baglantiString = "[Api-Keyi-Yazın]";
                HttpClient httpClient = new HttpClient();
                if (islemTuru == 0)
                {
                    // 0 manuel kargo
                    string icerikString = @"{
                    'name':'manuel',
                    'musteriAdi':'" + dizi[0] + "'," +
                        "'musteriLat':'" + dizi[1] + "'," +
                        "'musteriLng':'" + dizi[2] + "'" +
                        "}";

                    var icerikJson = JObject.Parse(icerikString);
                    var cevap = await httpClient.PostAsync(baglantiString, new StringContent(icerikJson.ToString()));
                    musterileriCek();
                    teslimatDurumEkraniGüncelle();
                    MessageBox.Show("Api tarafından manuel olarak kargo eklendi.", "Manuel Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else if (islemTuru == 1)
                {
                    // 1 hazir kargo
                    string icerikString = @"{
                    'name':'hazir',
                    'musteriId':'" + dizi[0] + "'," +
                        "}";

                    var icerikJson = JObject.Parse(icerikString);
                    var cevap = await httpClient.PostAsync(baglantiString, new StringContent(icerikJson.ToString()));
                    musterileriCek();
                    teslimatDurumEkraniGüncelle();
                    MessageBox.Show("Api tarafından hazir olarak kargo eklendi.", "Hazır Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void musterileriCek()
        {
            // Müşterileri Veritabanından çek
            musteriler = new List<List<string>>();
            try
            {
                SqlCommand musteriCekCmd = new SqlCommand("SELECT * FROM Musteriler", baglanti);
                baglanti.Open();
                SqlDataReader drMusteriCek = musteriCekCmd.ExecuteReader();

                while (drMusteriCek.Read())
                {
                    List<string> kayit = new List<string>();
                    kayit.Add(drMusteriCek["musteriId"].ToString());
                    kayit.Add(drMusteriCek["musteriAdi"].ToString());
                    kayit.Add(drMusteriCek["musteriLat"].ToString());
                    kayit.Add(drMusteriCek["musteriLng"].ToString());
                    musteriler.Add(kayit);

                }
                comboBoxMusteriler.Items.Clear();
                comboBoxMusteriler.Items.Add("Müşteri Seçiniz");
                for (int i = 0; i < musteriler.Count; i++)
                {
                    comboBoxMusteriler.Items.Add(musteriler[i][1]);
                }
                drMusteriCek.Close();
                comboBoxMusteriler.SelectedIndex = 0;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void teslimatDurumEkraniGüncelle()
        {
            dataGridViewTeslimatDurumu.Rows.Clear();
            //Kargolar tablosunu oku
            try
            {
                SqlCommand kargolarCekCmd = new SqlCommand("SELECT * FROM Kargolar", baglanti);
                baglanti.Open();
                SqlDataReader drKargolarCek = kargolarCekCmd.ExecuteReader();
                while (drKargolarCek.Read())
                {
                    
                    int musteriId = Convert.ToInt32(drKargolarCek[1]);
                    string musteriAdi = "";
                    
                    int kargoDurumu = Convert.ToInt32(drKargolarCek[2]);
                    string durum = "";
                    if (kargoDurumu == 0)
                        durum = "Teslim Edilecek";
                    else if (kargoDurumu == 1)
                        durum = "Teslim Ediliyor";
                    else if (kargoDurumu == 2)
                        durum = "Teslim Edildi";
                    
                    string adres = "";
                    SqlConnection baglanti2 = new SqlConnection("[Veritabanı-Bağlantı-Stringi-Yazın]");
                    SqlCommand musteriAdresCmd = new SqlCommand("SELECT * FROM Musteriler WHERE musteriId ="+ musteriId, baglanti2);
                    baglanti2.Open();
                    //drKargolarCek.Close();
                    SqlDataReader drMusteriAdresCek = musteriAdresCmd.ExecuteReader();
                    if (drMusteriAdresCek.Read())
                    {
                        musteriAdi = drMusteriAdresCek[1].ToString();
                        double lat = Convert.ToDouble(drMusteriAdresCek[2]);
                        double lng = Convert.ToDouble(drMusteriAdresCek[3]);
                        List<Placemark> placemarks = null;
                        //GeoCoderStatusCode statusCode = GMapProviders.OpenStreetMap.GetPlacemarks(new PointLatLng(lat, lng), out placemarks);
                        GeoCoderStatusCode statusCode = GeoCoderStatusCode.ZERO_RESULTS;
                        Placemark placemark = (Placemark)GMapProviders.OpenStreetMap.GetPlacemark(new PointLatLng(lat, lng), out statusCode);
                        //MessageBox.Show(statusCode.ToString());
                        if (statusCode == GeoCoderStatusCode.OK && !placemark.Address.Equals(String.Empty))
                        {
                            adres = placemark.Address.ToString();
                            
                        }
                    }

                    //baglanti.Open();
                    dataGridViewTeslimatDurumu.Rows.Add(musteriId, musteriAdi, adres, durum);
                    drMusteriAdresCek.Close();
                    baglanti2.Close();

                }
                drKargolarCek.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttonKullaniciSifreDegis_Click(object sender, EventArgs e)
        {
            if (groupBoxSifreDegistir.Visible == false)
                groupBoxSifreDegistir.Visible = true;
            else
            {
                groupBoxSifreDegistir.Visible = false;
                textBoxKullaniciSifreDegisSifre1.Text = "";
                textBoxKullaniciSifreDegisSifre2.Text = "";
            }
        }

        private void textBoxKullaniciSifreDegisSifre1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKullaniciSifreDegisSifre1.Text.Equals(textBoxKullaniciSifreDegisSifre2.Text))
                buttonKullaniciSifreDegisOnayla.Enabled = true;
            else
                buttonKullaniciSifreDegisOnayla.Enabled = false;
        }

        private void formAnaEkran_Load(object sender, EventArgs e)
        {
            GoogleMapProvider.Instance.ApiKey = "[GoogleMap-Api-Keyi-Yazın]";
        }

        private void textBoxKullaniciGirisAd_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxKullaniciGirisAd.Text.Equals(String.Empty) && !textBoxKullaniciGirisSifre.Text.Equals(String.Empty))
                buttonKullaniciGirisYap.Enabled = true;
            else
                buttonKullaniciGirisYap.Enabled = false;
        }

        private void buttonKullaniciGirisYap_Click(object sender, EventArgs e)
        {
            // Kullanici Girişi
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE kullaniciAdi='"+ textBoxKullaniciGirisAd.Text + "' AND kullaniciSifre ='" + textBoxKullaniciGirisSifre.Text+ "'",baglanti);
            try
            {
                PointLatLng kargoBayi = new PointLatLng(40.82385491536984,29.925228938634724);
                baglanti.Open();
                //cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxKullaniciGirisAd.Text = "";
                    textBoxKullaniciGirisSifre.Text = "";
                    

                    // Teslimat Sayfası Harita Yükleme Ön ayarlı konum İstanbul
                    gMapControlTeslimat.Visible = true;
                    gMapControlTeslimat.MapProvider = GMapProviders.GoogleMap;
                    gMapControlTeslimat.Position = kargoBayi;
                    gMapControlTeslimat.DragButton = MouseButtons.Right;
                    gMapControlTeslimat.ShowCenter = false;

                    // Harita Sayfası Harita Yükleme Ön ayarlı konum İstanbul
                    gMapControlHarita.Visible = true;
                    gMapControlHarita.MapProvider = GMapProviders.GoogleMap;
                    gMapControlHarita.Position = kargoBayi;
                    gMapControlHarita.DragButton = MouseButtons.Right;
                    gMapControlHarita.ShowCenter = false;

                    labelKullaniciAdi.Text = dr["kullaniciAdi"].ToString();
                    kullaniciId = Convert.ToInt32(dr["Id"]);
                    panelKullanici.Visible = true;
                    splitContainerKullaniciGirisKayit.Visible = false;

                    groupBoxTeslimatAdresEkrani.Visible = true;
                    groupBoxTeslimatAdresManuelGiris.Visible = true;
                    groupBoxTeslimatDurumEkrani.Visible = true;
                    dr.Close();
                    baglanti.Close();
                    musterileriCek();
                    teslimatDurumEkraniGüncelle();
                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxKullaniciGirisAd.Text = "";
                    textBoxKullaniciGirisSifre.Text = "";
                }
                
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                
                baglanti.Close();
            }
        }

        private void buttonKullaniciCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış Yapıldı", "Çıkış", MessageBoxButtons.OK, MessageBoxIcon.Information);
            splitContainerKullaniciGirisKayit.Visible = true;
            panelKullanici.Visible = false;
            gMapControlTeslimat.Visible = false;
            gMapControlHarita.Visible = false;
            groupBoxTeslimatAdresEkrani.Visible = false;
            groupBoxTeslimatAdresManuelGiris.Visible = false;
            groupBoxTeslimatDurumEkrani.Visible = false;
        }

        private void buttonKullaniciKayit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Kullanicilar (kullaniciAdi,kullaniciSifre) VALUES ('"+textBoxKayitKullaniciAd.Text+"','"+textBoxKullaniciKayitSifre.Text+"')", baglanti);
            try
            {
                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxKayitKullaniciAd.Text = "";
                textBoxKullaniciKayitSifre.Text = "";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void textBoxKayitKullaniciAd_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxKayitKullaniciAd.Text.Equals(String.Empty) && !textBoxKullaniciKayitSifre.Text.Equals(String.Empty))
                buttonKullaniciKayit.Enabled = true;
            else
                buttonKullaniciKayit.Enabled = false;
        }

        private void buttonKullaniciSifreDegisOnayla_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET kullaniciSifre = '" + textBoxKullaniciSifreDegisSifre1.Text + "' WHERE Id = '" + kullaniciId + "'", baglanti);
            try
            {
                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifre güncelleme başarılı", "Şifre Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxKullaniciSifreDegisSifre1.Text = "";
                textBoxKullaniciSifreDegisSifre2.Text = "";
                groupBoxSifreDegistir.Visible = false;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void gMapControlTeslimat_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (kargoBayiKonumu.IsEmpty)
                {
                    kargoBayiKonumu = gMapControlTeslimat.FromLocalToLatLng(e.X, e.Y);
                    GMapMarker marker = new GMarkerGoogle(kargoBayiKonumu, GMarkerGoogleType.green_dot);
                    GMapOverlay markers = new GMapOverlay("markers");
                    markers.Markers.Add(marker);
                    gMapControlTeslimat.Overlays.Add(markers);
                    gMapControlTeslimat.Position = kargoBayiKonumu;
                    buttonBayiKonum.Enabled = true;

                }
                else
                {
                    PointLatLng konum = gMapControlTeslimat.FromLocalToLatLng(e.X, e.Y);
                    textBoxLatitute.Text = konum.Lat.ToString();
                    textBoxLongitude.Text = konum.Lng.ToString();

                    GMapMarker marker = new GMarkerGoogle(konum, GMarkerGoogleType.red_dot);
                    GMapOverlay markers = new GMapOverlay("markers");
                    markers.Markers.Add(marker);
                    gMapControlTeslimat.Overlays.Add(markers);
                    gMapControlTeslimat.Position = konum;
                }

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttonBayiKonum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bayi konumu belirlendi.", "Bayi Konum", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelBayi.Text = "Bayi Konumu Belirlendi";
            buttonBayiKonum.Enabled = false;
            buttonDagitimaBasla.Enabled = true;
            kargocuAnlikKonum = kargoBayiKonumu;
        }

        private void textBoxLatitute_TextChanged(object sender, EventArgs e)
        {
            if(!textBoxLatitute.Text.Equals(String.Empty) && !textBoxLongitude.Text.Equals(String.Empty) && !textBoxMusteriAdi.Text.Equals(String.Empty))
            {
                buttonMusteriKargoEkle.Enabled = true;

            }
            else
            {
                buttonMusteriKargoEkle.Enabled = false;
            }

            if (!textBoxLatitute.Text.Equals(String.Empty) && !textBoxLongitude.Text.Equals(String.Empty))
            {
                PointLatLng yeniKonum = new PointLatLng(Convert.ToDouble(textBoxLatitute.Text), Convert.ToDouble(textBoxLongitude.Text));
                GMapMarker marker = new GMarkerGoogle(yeniKonum, GMarkerGoogleType.red_dot);
                GMapOverlay markers = new GMapOverlay("markers");
                gMapControlTeslimat.Overlays.RemoveAt(gMapControlTeslimat.Overlays.Count - 1);
                markers.Markers.Add(marker);
                gMapControlTeslimat.Overlays.Add(markers);
                gMapControlTeslimat.Position = yeniKonum;
            }



        }

        private void buttonMusteriKargoEkle_Click(object sender, EventArgs e)
        {
            string lat = Convert.ToDouble(textBoxLatitute.Text).ToString().Replace(",",".");
            string lng  = Convert.ToDouble(textBoxLongitude.Text).ToString().Replace(",", ".");

            string []dizi = new string[3];

            dizi[0] = textBoxMusteriAdi.Text;
            dizi[1] = lat;
            dizi[2] = lng;
            textBoxLatitute.Text = "";
            textBoxLongitude.Text = "";
            textBoxMusteriAdi.Text = "";
            apiIslemleri(0, dizi);
        }

        private void comboBoxMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMusteriler.SelectedIndex != 0 && !kargoBayiKonumu.IsEmpty)
            {
                buttonHazirKargoEkle.Enabled = true;
                PointLatLng yeniKonum = new PointLatLng(Convert.ToDouble(musteriler[comboBoxMusteriler.SelectedIndex-1][2]), Convert.ToDouble(musteriler[comboBoxMusteriler.SelectedIndex-1][3]));
                GMapMarker marker = new GMarkerGoogle(yeniKonum, GMarkerGoogleType.red_dot);
                GMapOverlay markers = new GMapOverlay("markers");
                gMapControlTeslimat.Overlays.RemoveAt(gMapControlTeslimat.Overlays.Count - 1);
                markers.Markers.Add(marker);
                gMapControlTeslimat.Overlays.Add(markers);
                gMapControlTeslimat.Position = yeniKonum;
            }
            else
            {
                buttonHazirKargoEkle.Enabled = false;
                comboBoxMusteriler.SelectedIndex = 0;
            }
        }

        private void buttonHazirKargoEkle_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[3];
            dizi[0] = musteriler[comboBoxMusteriler.SelectedIndex - 1][0];
            apiIslemleri(1, dizi);
        }

        private void buttonDagitimaBasla_Click(object sender, EventArgs e)
        {
            buttonKullaniciCikis.Enabled = false;
            tabControlMenu.SelectedTab = tabPageHarita;
            kargoDagitim = new Thread(teslimatSirasiHesaplaVeCizdir);
            kargoDagitim.Start();
        }
    }
}
