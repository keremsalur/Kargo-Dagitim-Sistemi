
namespace Yazlab_Proje_1_1
{
    partial class formAnaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabPageKullanici = new System.Windows.Forms.TabPage();
            this.splitContainerGUI1 = new System.Windows.Forms.SplitContainer();
            this.splitContainerKullanici = new System.Windows.Forms.SplitContainer();
            this.panelKullanici = new System.Windows.Forms.Panel();
            this.buttonKullaniciCikis = new System.Windows.Forms.Button();
            this.buttonKullaniciSifreDegis = new System.Windows.Forms.Button();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.groupBoxSifreDegistir = new System.Windows.Forms.GroupBox();
            this.buttonKullaniciSifreDegisOnayla = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKullaniciSifreDegisSifre1 = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciSifreDegisSifre2 = new System.Windows.Forms.TextBox();
            this.splitContainerKullaniciGirisKayit = new System.Windows.Forms.SplitContainer();
            this.buttonKullaniciGirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKullaniciGirisSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciGirisAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKullaniciKayit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKullaniciKayitSifre = new System.Windows.Forms.TextBox();
            this.textBoxKayitKullaniciAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainerTeslimat = new System.Windows.Forms.SplitContainer();
            this.groupBoxTeslimatAdresManuelGiris = new System.Windows.Forms.GroupBox();
            this.buttonDagitimaBasla = new System.Windows.Forms.Button();
            this.labelBayi = new System.Windows.Forms.Label();
            this.buttonBayiKonum = new System.Windows.Forms.Button();
            this.buttonHazirKargoEkle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxMusteriler = new System.Windows.Forms.ComboBox();
            this.buttonMusteriKargoEkle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMusteriAdi = new System.Windows.Forms.TextBox();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.textBoxLatitute = new System.Windows.Forms.TextBox();
            this.groupBoxTeslimatAdresEkrani = new System.Windows.Forms.GroupBox();
            this.gMapControlTeslimat = new GMap.NET.WindowsForms.GMapControl();
            this.groupBoxTeslimatDurumEkrani = new System.Windows.Forms.GroupBox();
            this.dataGridViewTeslimatDurumu = new System.Windows.Forms.DataGridView();
            this.tabPageHarita = new System.Windows.Forms.TabPage();
            this.gMapControlHarita = new GMap.NET.WindowsForms.GMapControl();
            this.musteriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterdiAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriaAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimatDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMenu.SuspendLayout();
            this.tabPageKullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGUI1)).BeginInit();
            this.splitContainerGUI1.Panel1.SuspendLayout();
            this.splitContainerGUI1.Panel2.SuspendLayout();
            this.splitContainerGUI1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKullanici)).BeginInit();
            this.splitContainerKullanici.Panel1.SuspendLayout();
            this.splitContainerKullanici.Panel2.SuspendLayout();
            this.splitContainerKullanici.SuspendLayout();
            this.panelKullanici.SuspendLayout();
            this.groupBoxSifreDegistir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKullaniciGirisKayit)).BeginInit();
            this.splitContainerKullaniciGirisKayit.Panel1.SuspendLayout();
            this.splitContainerKullaniciGirisKayit.Panel2.SuspendLayout();
            this.splitContainerKullaniciGirisKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTeslimat)).BeginInit();
            this.splitContainerTeslimat.Panel1.SuspendLayout();
            this.splitContainerTeslimat.Panel2.SuspendLayout();
            this.splitContainerTeslimat.SuspendLayout();
            this.groupBoxTeslimatAdresManuelGiris.SuspendLayout();
            this.groupBoxTeslimatAdresEkrani.SuspendLayout();
            this.groupBoxTeslimatDurumEkrani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeslimatDurumu)).BeginInit();
            this.tabPageHarita.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageKullanici);
            this.tabControlMenu.Controls.Add(this.tabPageHarita);
            this.tabControlMenu.HotTrack = true;
            this.tabControlMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlMenu.Location = new System.Drawing.Point(1, 3);
            this.tabControlMenu.Multiline = true;
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(1283, 722);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPageKullanici
            // 
            this.tabPageKullanici.Controls.Add(this.splitContainerGUI1);
            this.tabPageKullanici.Location = new System.Drawing.Point(4, 22);
            this.tabPageKullanici.Name = "tabPageKullanici";
            this.tabPageKullanici.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKullanici.Size = new System.Drawing.Size(1275, 696);
            this.tabPageKullanici.TabIndex = 0;
            this.tabPageKullanici.Text = "Kullanıcı";
            this.tabPageKullanici.UseVisualStyleBackColor = true;
            // 
            // splitContainerGUI1
            // 
            this.splitContainerGUI1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerGUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGUI1.IsSplitterFixed = true;
            this.splitContainerGUI1.Location = new System.Drawing.Point(3, 3);
            this.splitContainerGUI1.Name = "splitContainerGUI1";
            // 
            // splitContainerGUI1.Panel1
            // 
            this.splitContainerGUI1.Panel1.Controls.Add(this.splitContainerKullanici);
            // 
            // splitContainerGUI1.Panel2
            // 
            this.splitContainerGUI1.Panel2.Controls.Add(this.splitContainerTeslimat);
            this.splitContainerGUI1.Size = new System.Drawing.Size(1269, 690);
            this.splitContainerGUI1.SplitterDistance = 221;
            this.splitContainerGUI1.TabIndex = 0;
            // 
            // splitContainerKullanici
            // 
            this.splitContainerKullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerKullanici.Location = new System.Drawing.Point(0, 0);
            this.splitContainerKullanici.Name = "splitContainerKullanici";
            this.splitContainerKullanici.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerKullanici.Panel1
            // 
            this.splitContainerKullanici.Panel1.Controls.Add(this.panelKullanici);
            this.splitContainerKullanici.Panel1.Controls.Add(this.groupBoxSifreDegistir);
            // 
            // splitContainerKullanici.Panel2
            // 
            this.splitContainerKullanici.Panel2.Controls.Add(this.splitContainerKullaniciGirisKayit);
            this.splitContainerKullanici.Size = new System.Drawing.Size(221, 690);
            this.splitContainerKullanici.SplitterDistance = 210;
            this.splitContainerKullanici.TabIndex = 0;
            // 
            // panelKullanici
            // 
            this.panelKullanici.Controls.Add(this.buttonKullaniciCikis);
            this.panelKullanici.Controls.Add(this.buttonKullaniciSifreDegis);
            this.panelKullanici.Controls.Add(this.labelKullaniciAdi);
            this.panelKullanici.Location = new System.Drawing.Point(7, 10);
            this.panelKullanici.Name = "panelKullanici";
            this.panelKullanici.Size = new System.Drawing.Size(200, 82);
            this.panelKullanici.TabIndex = 0;
            this.panelKullanici.Visible = false;
            // 
            // buttonKullaniciCikis
            // 
            this.buttonKullaniciCikis.Location = new System.Drawing.Point(110, 16);
            this.buttonKullaniciCikis.Name = "buttonKullaniciCikis";
            this.buttonKullaniciCikis.Size = new System.Drawing.Size(75, 23);
            this.buttonKullaniciCikis.TabIndex = 1;
            this.buttonKullaniciCikis.Text = "Çıkış Yap";
            this.buttonKullaniciCikis.UseVisualStyleBackColor = true;
            this.buttonKullaniciCikis.Click += new System.EventHandler(this.buttonKullaniciCikis_Click);
            // 
            // buttonKullaniciSifreDegis
            // 
            this.buttonKullaniciSifreDegis.Location = new System.Drawing.Point(110, 45);
            this.buttonKullaniciSifreDegis.Name = "buttonKullaniciSifreDegis";
            this.buttonKullaniciSifreDegis.Size = new System.Drawing.Size(75, 23);
            this.buttonKullaniciSifreDegis.TabIndex = 2;
            this.buttonKullaniciSifreDegis.Text = "Şifre Değiştir";
            this.buttonKullaniciSifreDegis.UseVisualStyleBackColor = true;
            this.buttonKullaniciSifreDegis.Click += new System.EventHandler(this.buttonKullaniciSifreDegis_Click);
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullaniciAdi.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(8, 23);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(0, 16);
            this.labelKullaniciAdi.TabIndex = 0;
            // 
            // groupBoxSifreDegistir
            // 
            this.groupBoxSifreDegistir.Controls.Add(this.buttonKullaniciSifreDegisOnayla);
            this.groupBoxSifreDegistir.Controls.Add(this.label8);
            this.groupBoxSifreDegistir.Controls.Add(this.label7);
            this.groupBoxSifreDegistir.Controls.Add(this.textBoxKullaniciSifreDegisSifre1);
            this.groupBoxSifreDegistir.Controls.Add(this.textBoxKullaniciSifreDegisSifre2);
            this.groupBoxSifreDegistir.Location = new System.Drawing.Point(7, 98);
            this.groupBoxSifreDegistir.Name = "groupBoxSifreDegistir";
            this.groupBoxSifreDegistir.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSifreDegistir.TabIndex = 0;
            this.groupBoxSifreDegistir.TabStop = false;
            this.groupBoxSifreDegistir.Text = "Şifre Değiştir";
            this.groupBoxSifreDegistir.Visible = false;
            // 
            // buttonKullaniciSifreDegisOnayla
            // 
            this.buttonKullaniciSifreDegisOnayla.Enabled = false;
            this.buttonKullaniciSifreDegisOnayla.Location = new System.Drawing.Point(114, 68);
            this.buttonKullaniciSifreDegisOnayla.Name = "buttonKullaniciSifreDegisOnayla";
            this.buttonKullaniciSifreDegisOnayla.Size = new System.Drawing.Size(75, 23);
            this.buttonKullaniciSifreDegisOnayla.TabIndex = 5;
            this.buttonKullaniciSifreDegisOnayla.Text = "Onayla";
            this.buttonKullaniciSifreDegisOnayla.UseVisualStyleBackColor = true;
            this.buttonKullaniciSifreDegisOnayla.Click += new System.EventHandler(this.buttonKullaniciSifreDegisOnayla_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(50, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Şifre";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şifre Tekrar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxKullaniciSifreDegisSifre1
            // 
            this.textBoxKullaniciSifreDegisSifre1.Location = new System.Drawing.Point(91, 15);
            this.textBoxKullaniciSifreDegisSifre1.Name = "textBoxKullaniciSifreDegisSifre1";
            this.textBoxKullaniciSifreDegisSifre1.PasswordChar = '*';
            this.textBoxKullaniciSifreDegisSifre1.Size = new System.Drawing.Size(100, 20);
            this.textBoxKullaniciSifreDegisSifre1.TabIndex = 8;
            this.textBoxKullaniciSifreDegisSifre1.TextChanged += new System.EventHandler(this.textBoxKullaniciSifreDegisSifre1_TextChanged);
            // 
            // textBoxKullaniciSifreDegisSifre2
            // 
            this.textBoxKullaniciSifreDegisSifre2.Location = new System.Drawing.Point(91, 42);
            this.textBoxKullaniciSifreDegisSifre2.Name = "textBoxKullaniciSifreDegisSifre2";
            this.textBoxKullaniciSifreDegisSifre2.PasswordChar = '*';
            this.textBoxKullaniciSifreDegisSifre2.Size = new System.Drawing.Size(100, 20);
            this.textBoxKullaniciSifreDegisSifre2.TabIndex = 9;
            this.textBoxKullaniciSifreDegisSifre2.TextChanged += new System.EventHandler(this.textBoxKullaniciSifreDegisSifre1_TextChanged);
            // 
            // splitContainerKullaniciGirisKayit
            // 
            this.splitContainerKullaniciGirisKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerKullaniciGirisKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerKullaniciGirisKayit.Location = new System.Drawing.Point(0, 0);
            this.splitContainerKullaniciGirisKayit.Name = "splitContainerKullaniciGirisKayit";
            this.splitContainerKullaniciGirisKayit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerKullaniciGirisKayit.Panel1
            // 
            this.splitContainerKullaniciGirisKayit.Panel1.Controls.Add(this.buttonKullaniciGirisYap);
            this.splitContainerKullaniciGirisKayit.Panel1.Controls.Add(this.label1);
            this.splitContainerKullaniciGirisKayit.Panel1.Controls.Add(this.label3);
            this.splitContainerKullaniciGirisKayit.Panel1.Controls.Add(this.textBoxKullaniciGirisSifre);
            this.splitContainerKullaniciGirisKayit.Panel1.Controls.Add(this.textBoxKullaniciGirisAd);
            this.splitContainerKullaniciGirisKayit.Panel1.Controls.Add(this.label2);
            // 
            // splitContainerKullaniciGirisKayit.Panel2
            // 
            this.splitContainerKullaniciGirisKayit.Panel2.Controls.Add(this.buttonKullaniciKayit);
            this.splitContainerKullaniciGirisKayit.Panel2.Controls.Add(this.label4);
            this.splitContainerKullaniciGirisKayit.Panel2.Controls.Add(this.label5);
            this.splitContainerKullaniciGirisKayit.Panel2.Controls.Add(this.textBoxKullaniciKayitSifre);
            this.splitContainerKullaniciGirisKayit.Panel2.Controls.Add(this.textBoxKayitKullaniciAd);
            this.splitContainerKullaniciGirisKayit.Panel2.Controls.Add(this.label6);
            this.splitContainerKullaniciGirisKayit.Size = new System.Drawing.Size(221, 476);
            this.splitContainerKullaniciGirisKayit.SplitterDistance = 225;
            this.splitContainerKullaniciGirisKayit.TabIndex = 0;
            // 
            // buttonKullaniciGirisYap
            // 
            this.buttonKullaniciGirisYap.Enabled = false;
            this.buttonKullaniciGirisYap.Location = new System.Drawing.Point(113, 160);
            this.buttonKullaniciGirisYap.Name = "buttonKullaniciGirisYap";
            this.buttonKullaniciGirisYap.Size = new System.Drawing.Size(75, 23);
            this.buttonKullaniciGirisYap.TabIndex = 0;
            this.buttonKullaniciGirisYap.Text = "Giriş Yap";
            this.buttonKullaniciGirisYap.UseVisualStyleBackColor = true;
            this.buttonKullaniciGirisYap.Click += new System.EventHandler(this.buttonKullaniciGirisYap_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxKullaniciGirisSifre
            // 
            this.textBoxKullaniciGirisSifre.Location = new System.Drawing.Point(101, 123);
            this.textBoxKullaniciGirisSifre.Name = "textBoxKullaniciGirisSifre";
            this.textBoxKullaniciGirisSifre.PasswordChar = '*';
            this.textBoxKullaniciGirisSifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxKullaniciGirisSifre.TabIndex = 4;
            this.textBoxKullaniciGirisSifre.TextChanged += new System.EventHandler(this.textBoxKullaniciGirisAd_TextChanged);
            // 
            // textBoxKullaniciGirisAd
            // 
            this.textBoxKullaniciGirisAd.Location = new System.Drawing.Point(101, 96);
            this.textBoxKullaniciGirisAd.Name = "textBoxKullaniciGirisAd";
            this.textBoxKullaniciGirisAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxKullaniciGirisAd.TabIndex = 3;
            this.textBoxKullaniciGirisAd.TextChanged += new System.EventHandler(this.textBoxKullaniciGirisAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKullaniciKayit
            // 
            this.buttonKullaniciKayit.Enabled = false;
            this.buttonKullaniciKayit.Location = new System.Drawing.Point(113, 166);
            this.buttonKullaniciKayit.Name = "buttonKullaniciKayit";
            this.buttonKullaniciKayit.Size = new System.Drawing.Size(75, 23);
            this.buttonKullaniciKayit.TabIndex = 5;
            this.buttonKullaniciKayit.Text = "Kayıt Ol";
            this.buttonKullaniciKayit.UseVisualStyleBackColor = true;
            this.buttonKullaniciKayit.Click += new System.EventHandler(this.buttonKullaniciKayit_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(2, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kullanıcı Kayıt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(60, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Şifre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxKullaniciKayitSifre
            // 
            this.textBoxKullaniciKayitSifre.Location = new System.Drawing.Point(101, 129);
            this.textBoxKullaniciKayitSifre.Name = "textBoxKullaniciKayitSifre";
            this.textBoxKullaniciKayitSifre.PasswordChar = '*';
            this.textBoxKullaniciKayitSifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxKullaniciKayitSifre.TabIndex = 10;
            this.textBoxKullaniciKayitSifre.TextChanged += new System.EventHandler(this.textBoxKayitKullaniciAd_TextChanged);
            // 
            // textBoxKayitKullaniciAd
            // 
            this.textBoxKayitKullaniciAd.Location = new System.Drawing.Point(101, 102);
            this.textBoxKayitKullaniciAd.Name = "textBoxKayitKullaniciAd";
            this.textBoxKayitKullaniciAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxKayitKullaniciAd.TabIndex = 9;
            this.textBoxKayitKullaniciAd.TextChanged += new System.EventHandler(this.textBoxKayitKullaniciAd_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kullanıcı Adı";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainerTeslimat
            // 
            this.splitContainerTeslimat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTeslimat.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTeslimat.Name = "splitContainerTeslimat";
            this.splitContainerTeslimat.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTeslimat.Panel1
            // 
            this.splitContainerTeslimat.Panel1.Controls.Add(this.groupBoxTeslimatAdresManuelGiris);
            this.splitContainerTeslimat.Panel1.Controls.Add(this.groupBoxTeslimatAdresEkrani);
            // 
            // splitContainerTeslimat.Panel2
            // 
            this.splitContainerTeslimat.Panel2.Controls.Add(this.groupBoxTeslimatDurumEkrani);
            this.splitContainerTeslimat.Size = new System.Drawing.Size(1042, 688);
            this.splitContainerTeslimat.SplitterDistance = 437;
            this.splitContainerTeslimat.TabIndex = 0;
            // 
            // groupBoxTeslimatAdresManuelGiris
            // 
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.buttonDagitimaBasla);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.labelBayi);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.buttonBayiKonum);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.buttonHazirKargoEkle);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.label12);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.comboBoxMusteriler);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.buttonMusteriKargoEkle);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.label11);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.label10);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.label9);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.textBoxMusteriAdi);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.textBoxLongitude);
            this.groupBoxTeslimatAdresManuelGiris.Controls.Add(this.textBoxLatitute);
            this.groupBoxTeslimatAdresManuelGiris.Location = new System.Drawing.Point(875, 10);
            this.groupBoxTeslimatAdresManuelGiris.Name = "groupBoxTeslimatAdresManuelGiris";
            this.groupBoxTeslimatAdresManuelGiris.Size = new System.Drawing.Size(163, 418);
            this.groupBoxTeslimatAdresManuelGiris.TabIndex = 2;
            this.groupBoxTeslimatAdresManuelGiris.TabStop = false;
            this.groupBoxTeslimatAdresManuelGiris.Text = "Teslimat Adresi Manuel Giriş";
            this.groupBoxTeslimatAdresManuelGiris.Visible = false;
            // 
            // buttonDagitimaBasla
            // 
            this.buttonDagitimaBasla.Enabled = false;
            this.buttonDagitimaBasla.Location = new System.Drawing.Point(27, 328);
            this.buttonDagitimaBasla.Name = "buttonDagitimaBasla";
            this.buttonDagitimaBasla.Size = new System.Drawing.Size(111, 23);
            this.buttonDagitimaBasla.TabIndex = 14;
            this.buttonDagitimaBasla.Text = "Dağıtıma Başla";
            this.buttonDagitimaBasla.UseVisualStyleBackColor = true;
            this.buttonDagitimaBasla.Click += new System.EventHandler(this.buttonDagitimaBasla_Click);
            // 
            // labelBayi
            // 
            this.labelBayi.AutoSize = true;
            this.labelBayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBayi.Location = new System.Drawing.Point(3, 364);
            this.labelBayi.Name = "labelBayi";
            this.labelBayi.Size = new System.Drawing.Size(156, 13);
            this.labelBayi.TabIndex = 13;
            this.labelBayi.Text = "Kargo Bayi Konumunu Belirleyin";
            // 
            // buttonBayiKonum
            // 
            this.buttonBayiKonum.Enabled = false;
            this.buttonBayiKonum.Location = new System.Drawing.Point(27, 389);
            this.buttonBayiKonum.Name = "buttonBayiKonum";
            this.buttonBayiKonum.Size = new System.Drawing.Size(111, 23);
            this.buttonBayiKonum.TabIndex = 12;
            this.buttonBayiKonum.Text = "Kargo Bayi Konumu";
            this.buttonBayiKonum.UseVisualStyleBackColor = true;
            this.buttonBayiKonum.Click += new System.EventHandler(this.buttonBayiKonum_Click);
            // 
            // buttonHazirKargoEkle
            // 
            this.buttonHazirKargoEkle.Enabled = false;
            this.buttonHazirKargoEkle.Location = new System.Drawing.Point(46, 268);
            this.buttonHazirKargoEkle.Name = "buttonHazirKargoEkle";
            this.buttonHazirKargoEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonHazirKargoEkle.TabIndex = 11;
            this.buttonHazirKargoEkle.Text = "Kargo Ekle";
            this.buttonHazirKargoEkle.UseVisualStyleBackColor = true;
            this.buttonHazirKargoEkle.Click += new System.EventHandler(this.buttonHazirKargoEkle_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Kayıtlı Müşteriler";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxMusteriler
            // 
            this.comboBoxMusteriler.FormattingEnabled = true;
            this.comboBoxMusteriler.Location = new System.Drawing.Point(9, 241);
            this.comboBoxMusteriler.Name = "comboBoxMusteriler";
            this.comboBoxMusteriler.Size = new System.Drawing.Size(148, 21);
            this.comboBoxMusteriler.TabIndex = 9;
            this.comboBoxMusteriler.SelectedIndexChanged += new System.EventHandler(this.comboBoxMusteriler_SelectedIndexChanged);
            // 
            // buttonMusteriKargoEkle
            // 
            this.buttonMusteriKargoEkle.Enabled = false;
            this.buttonMusteriKargoEkle.Location = new System.Drawing.Point(46, 156);
            this.buttonMusteriKargoEkle.Name = "buttonMusteriKargoEkle";
            this.buttonMusteriKargoEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonMusteriKargoEkle.TabIndex = 8;
            this.buttonMusteriKargoEkle.Text = "Kargo Ekle";
            this.buttonMusteriKargoEkle.UseVisualStyleBackColor = true;
            this.buttonMusteriKargoEkle.Click += new System.EventHandler(this.buttonMusteriKargoEkle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Müşteri Adı";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Longtitude";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Latitute";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMusteriAdi
            // 
            this.textBoxMusteriAdi.Location = new System.Drawing.Point(6, 127);
            this.textBoxMusteriAdi.Name = "textBoxMusteriAdi";
            this.textBoxMusteriAdi.Size = new System.Drawing.Size(151, 20);
            this.textBoxMusteriAdi.TabIndex = 4;
            this.textBoxMusteriAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMusteriAdi.TextChanged += new System.EventHandler(this.textBoxLatitute_TextChanged);
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(6, 78);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(151, 20);
            this.textBoxLongitude.TabIndex = 3;
            this.textBoxLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLongitude.TextChanged += new System.EventHandler(this.textBoxLatitute_TextChanged);
            // 
            // textBoxLatitute
            // 
            this.textBoxLatitute.Location = new System.Drawing.Point(6, 32);
            this.textBoxLatitute.Name = "textBoxLatitute";
            this.textBoxLatitute.Size = new System.Drawing.Size(151, 20);
            this.textBoxLatitute.TabIndex = 2;
            this.textBoxLatitute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLatitute.TextChanged += new System.EventHandler(this.textBoxLatitute_TextChanged);
            // 
            // groupBoxTeslimatAdresEkrani
            // 
            this.groupBoxTeslimatAdresEkrani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTeslimatAdresEkrani.Controls.Add(this.gMapControlTeslimat);
            this.groupBoxTeslimatAdresEkrani.Location = new System.Drawing.Point(2, 3);
            this.groupBoxTeslimatAdresEkrani.Name = "groupBoxTeslimatAdresEkrani";
            this.groupBoxTeslimatAdresEkrani.Size = new System.Drawing.Size(867, 431);
            this.groupBoxTeslimatAdresEkrani.TabIndex = 1;
            this.groupBoxTeslimatAdresEkrani.TabStop = false;
            this.groupBoxTeslimatAdresEkrani.Text = "Teslimat Adres Ekranı";
            this.groupBoxTeslimatAdresEkrani.Visible = false;
            // 
            // gMapControlTeslimat
            // 
            this.gMapControlTeslimat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControlTeslimat.Bearing = 0F;
            this.gMapControlTeslimat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControlTeslimat.CanDragMap = true;
            this.gMapControlTeslimat.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControlTeslimat.GrayScaleMode = false;
            this.gMapControlTeslimat.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlTeslimat.LevelsKeepInMemory = 5;
            this.gMapControlTeslimat.Location = new System.Drawing.Point(6, 19);
            this.gMapControlTeslimat.MarkersEnabled = true;
            this.gMapControlTeslimat.MaxZoom = 25;
            this.gMapControlTeslimat.MinZoom = 3;
            this.gMapControlTeslimat.MouseWheelZoomEnabled = true;
            this.gMapControlTeslimat.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControlTeslimat.Name = "gMapControlTeslimat";
            this.gMapControlTeslimat.NegativeMode = false;
            this.gMapControlTeslimat.PolygonsEnabled = true;
            this.gMapControlTeslimat.RetryLoadTile = 0;
            this.gMapControlTeslimat.RoutesEnabled = true;
            this.gMapControlTeslimat.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControlTeslimat.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControlTeslimat.ShowTileGridLines = false;
            this.gMapControlTeslimat.Size = new System.Drawing.Size(855, 406);
            this.gMapControlTeslimat.TabIndex = 1;
            this.gMapControlTeslimat.Visible = false;
            this.gMapControlTeslimat.Zoom = 15D;
            this.gMapControlTeslimat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControlTeslimat_MouseClick);
            // 
            // groupBoxTeslimatDurumEkrani
            // 
            this.groupBoxTeslimatDurumEkrani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTeslimatDurumEkrani.Controls.Add(this.dataGridViewTeslimatDurumu);
            this.groupBoxTeslimatDurumEkrani.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTeslimatDurumEkrani.Name = "groupBoxTeslimatDurumEkrani";
            this.groupBoxTeslimatDurumEkrani.Size = new System.Drawing.Size(1035, 236);
            this.groupBoxTeslimatDurumEkrani.TabIndex = 0;
            this.groupBoxTeslimatDurumEkrani.TabStop = false;
            this.groupBoxTeslimatDurumEkrani.Text = "Teslimat Durum Ekranı";
            this.groupBoxTeslimatDurumEkrani.Visible = false;
            // 
            // dataGridViewTeslimatDurumu
            // 
            this.dataGridViewTeslimatDurumu.AllowUserToAddRows = false;
            this.dataGridViewTeslimatDurumu.AllowUserToDeleteRows = false;
            this.dataGridViewTeslimatDurumu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeslimatDurumu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriId,
            this.musterdiAdi,
            this.musteriaAdres,
            this.teslimatDurumu});
            this.dataGridViewTeslimatDurumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTeslimatDurumu.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewTeslimatDurumu.Name = "dataGridViewTeslimatDurumu";
            this.dataGridViewTeslimatDurumu.Size = new System.Drawing.Size(1029, 217);
            this.dataGridViewTeslimatDurumu.TabIndex = 0;
            // 
            // tabPageHarita
            // 
            this.tabPageHarita.Controls.Add(this.gMapControlHarita);
            this.tabPageHarita.Location = new System.Drawing.Point(4, 22);
            this.tabPageHarita.Name = "tabPageHarita";
            this.tabPageHarita.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHarita.Size = new System.Drawing.Size(1275, 696);
            this.tabPageHarita.TabIndex = 1;
            this.tabPageHarita.Text = "Harita";
            this.tabPageHarita.UseVisualStyleBackColor = true;
            // 
            // gMapControlHarita
            // 
            this.gMapControlHarita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControlHarita.Bearing = 0F;
            this.gMapControlHarita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControlHarita.CanDragMap = true;
            this.gMapControlHarita.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControlHarita.GrayScaleMode = false;
            this.gMapControlHarita.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlHarita.LevelsKeepInMemory = 5;
            this.gMapControlHarita.Location = new System.Drawing.Point(7, 6);
            this.gMapControlHarita.MarkersEnabled = true;
            this.gMapControlHarita.MaxZoom = 25;
            this.gMapControlHarita.MinZoom = 3;
            this.gMapControlHarita.MouseWheelZoomEnabled = true;
            this.gMapControlHarita.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControlHarita.Name = "gMapControlHarita";
            this.gMapControlHarita.NegativeMode = false;
            this.gMapControlHarita.PolygonsEnabled = true;
            this.gMapControlHarita.RetryLoadTile = 0;
            this.gMapControlHarita.RoutesEnabled = true;
            this.gMapControlHarita.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControlHarita.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControlHarita.ShowTileGridLines = false;
            this.gMapControlHarita.Size = new System.Drawing.Size(1262, 678);
            this.gMapControlHarita.TabIndex = 0;
            this.gMapControlHarita.Visible = false;
            this.gMapControlHarita.Zoom = 15D;
            // 
            // musteriId
            // 
            this.musteriId.HeaderText = "Müşteri Id";
            this.musteriId.Name = "musteriId";
            this.musteriId.ReadOnly = true;
            // 
            // musterdiAdi
            // 
            this.musterdiAdi.HeaderText = "Müşteri Adı";
            this.musterdiAdi.Name = "musterdiAdi";
            // 
            // musteriaAdres
            // 
            this.musteriaAdres.HeaderText = "Müşteri Adresi";
            this.musteriaAdres.Name = "musteriaAdres";
            this.musteriaAdres.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.musteriaAdres.Width = 650;
            // 
            // teslimatDurumu
            // 
            this.teslimatDurumu.HeaderText = "Teslimat Durumu";
            this.teslimatDurumu.Name = "teslimatDurumu";
            this.teslimatDurumu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teslimatDurumu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.teslimatDurumu.Width = 130;
            // 
            // formAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 721);
            this.Controls.Add(this.tabControlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1304, 764);
            this.MinimumSize = new System.Drawing.Size(1304, 764);
            this.Name = "formAnaEkran";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Dağıtım Sistemi";
            this.Load += new System.EventHandler(this.formAnaEkran_Load);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageKullanici.ResumeLayout(false);
            this.splitContainerGUI1.Panel1.ResumeLayout(false);
            this.splitContainerGUI1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGUI1)).EndInit();
            this.splitContainerGUI1.ResumeLayout(false);
            this.splitContainerKullanici.Panel1.ResumeLayout(false);
            this.splitContainerKullanici.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKullanici)).EndInit();
            this.splitContainerKullanici.ResumeLayout(false);
            this.panelKullanici.ResumeLayout(false);
            this.panelKullanici.PerformLayout();
            this.groupBoxSifreDegistir.ResumeLayout(false);
            this.groupBoxSifreDegistir.PerformLayout();
            this.splitContainerKullaniciGirisKayit.Panel1.ResumeLayout(false);
            this.splitContainerKullaniciGirisKayit.Panel1.PerformLayout();
            this.splitContainerKullaniciGirisKayit.Panel2.ResumeLayout(false);
            this.splitContainerKullaniciGirisKayit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKullaniciGirisKayit)).EndInit();
            this.splitContainerKullaniciGirisKayit.ResumeLayout(false);
            this.splitContainerTeslimat.Panel1.ResumeLayout(false);
            this.splitContainerTeslimat.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTeslimat)).EndInit();
            this.splitContainerTeslimat.ResumeLayout(false);
            this.groupBoxTeslimatAdresManuelGiris.ResumeLayout(false);
            this.groupBoxTeslimatAdresManuelGiris.PerformLayout();
            this.groupBoxTeslimatAdresEkrani.ResumeLayout(false);
            this.groupBoxTeslimatDurumEkrani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeslimatDurumu)).EndInit();
            this.tabPageHarita.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageKullanici;
        private System.Windows.Forms.TabPage tabPageHarita;
        private System.Windows.Forms.SplitContainer splitContainerGUI1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKullaniciGirisSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciGirisAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKullaniciGirisYap;
        private System.Windows.Forms.SplitContainer splitContainerKullanici;
        private System.Windows.Forms.SplitContainer splitContainerKullaniciGirisKayit;
        private System.Windows.Forms.Button buttonKullaniciSifreDegisOnayla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKullaniciSifreDegisSifre2;
        private System.Windows.Forms.TextBox textBoxKullaniciSifreDegisSifre1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonKullaniciSifreDegis;
        private System.Windows.Forms.Button buttonKullaniciCikis;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Button buttonKullaniciKayit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKullaniciKayitSifre;
        private System.Windows.Forms.TextBox textBoxKayitKullaniciAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxSifreDegistir;
        private System.Windows.Forms.Panel panelKullanici;
        private GMap.NET.WindowsForms.GMapControl gMapControlHarita;
        private System.Windows.Forms.SplitContainer splitContainerTeslimat;
        private GMap.NET.WindowsForms.GMapControl gMapControlTeslimat;
        private System.Windows.Forms.GroupBox groupBoxTeslimatDurumEkrani;
        private System.Windows.Forms.GroupBox groupBoxTeslimatAdresEkrani;
        private System.Windows.Forms.GroupBox groupBoxTeslimatAdresManuelGiris;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.TextBox textBoxLatitute;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMusteriAdi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonBayiKonum;
        private System.Windows.Forms.Button buttonHazirKargoEkle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxMusteriler;
        private System.Windows.Forms.Button buttonMusteriKargoEkle;
        private System.Windows.Forms.Label labelBayi;
        private System.Windows.Forms.DataGridView dataGridViewTeslimatDurumu;
        private System.Windows.Forms.Button buttonDagitimaBasla;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn musterdiAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriaAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimatDurumu;
    }
}

