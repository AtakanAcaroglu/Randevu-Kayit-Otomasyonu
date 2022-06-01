
namespace Proje_şeysi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIsimSoyisim = new System.Windows.Forms.TextBox();
            this.btnKaydiTamamla = new System.Windows.Forms.Button();
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblIsimSoyisim = new System.Windows.Forms.Label();
            this.lblRandevuTarihi = new System.Windows.Forms.Label();
            this.lblMeslek = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lbl_TelefonNo = new System.Windows.Forms.Label();
            this.lblSikayet = new System.Windows.Forms.Label();
            this.lblAlınanNot = new System.Windows.Forms.Label();
            this.lblKullandigiIlaclar = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.txtAlınanNotlar = new System.Windows.Forms.TextBox();
            this.txtKullandigiIlaclar = new System.Windows.Forms.TextBox();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.rbtErkek = new System.Windows.Forms.RadioButton();
            this.rbtKadın = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.chxOnay = new System.Windows.Forms.CheckBox();
            this.cbxDoktor = new System.Windows.Forms.ComboBox();
            this.lblDoktor = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTelefonNmr = new System.Windows.Forms.Label();
            this.lblRandevuTrh = new System.Windows.Forms.Label();
            this.chxDetayliArama = new System.Windows.Forms.CheckBox();
            this.dtpArama = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.İsimSoyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meslek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Şikayeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandevuTar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlınanNotlar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kullandığıİlaçlar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TercihEdilenDoktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtImplantID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIslemID = new System.Windows.Forms.Label();
            this.txtHastaID = new System.Windows.Forms.TextBox();
            this.txtUygulananNokta = new System.Windows.Forms.TextBox();
            this.lblUygulananNokta = new System.Windows.Forms.Label();
            this.lblIslemTarihi = new System.Windows.Forms.Label();
            this.lsbIslemBilgileri = new System.Windows.Forms.ListBox();
            this.lblHastaID = new System.Windows.Forms.Label();
            this.lblIslemAdedi = new System.Windows.Forms.Label();
            this.txtIslemID = new System.Windows.Forms.TextBox();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTelArama = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchError = new System.Windows.Forms.Label();
            this.txtNameError = new System.Windows.Forms.Label();
            this.txtTelError = new System.Windows.Forms.Label();
            this.txtDocError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIsimSoyisim
            // 
            this.txtIsimSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsimSoyisim.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtIsimSoyisim.Location = new System.Drawing.Point(449, 176);
            this.txtIsimSoyisim.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsimSoyisim.Name = "txtIsimSoyisim";
            this.txtIsimSoyisim.Size = new System.Drawing.Size(355, 30);
            this.txtIsimSoyisim.TabIndex = 1;
            // 
            // btnKaydiTamamla
            // 
            this.btnKaydiTamamla.Enabled = false;
            this.btnKaydiTamamla.Location = new System.Drawing.Point(681, 533);
            this.btnKaydiTamamla.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydiTamamla.Name = "btnKaydiTamamla";
            this.btnKaydiTamamla.Size = new System.Drawing.Size(124, 30);
            this.btnKaydiTamamla.TabIndex = 5;
            this.btnKaydiTamamla.Text = "Kaydı Tamamla";
            this.btnKaydiTamamla.UseVisualStyleBackColor = true;
            this.btnKaydiTamamla.Click += new System.EventHandler(this.btnKaydiTamamla_Click);
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.CustomFormat = "dd/MM/yyyy HH:mm ";
            this.dtpRandevuTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpRandevuTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(449, 373);
            this.dtpRandevuTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(355, 30);
            this.dtpRandevuTarihi.TabIndex = 6;
            this.dtpRandevuTarihi.Value = new System.DateTime(2022, 5, 4, 0, 0, 0, 0);
            // 
            // lblIsimSoyisim
            // 
            this.lblIsimSoyisim.AutoSize = true;
            this.lblIsimSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsimSoyisim.Location = new System.Drawing.Point(308, 176);
            this.lblIsimSoyisim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsimSoyisim.Name = "lblIsimSoyisim";
            this.lblIsimSoyisim.Size = new System.Drawing.Size(127, 25);
            this.lblIsimSoyisim.TabIndex = 7;
            this.lblIsimSoyisim.Text = "İsim Soyisim:";
            this.lblIsimSoyisim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRandevuTarihi
            // 
            this.lblRandevuTarihi.AutoSize = true;
            this.lblRandevuTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRandevuTarihi.Location = new System.Drawing.Point(285, 373);
            this.lblRandevuTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRandevuTarihi.Name = "lblRandevuTarihi";
            this.lblRandevuTarihi.Size = new System.Drawing.Size(150, 25);
            this.lblRandevuTarihi.TabIndex = 8;
            this.lblRandevuTarihi.Text = "Randevu Tarihi:";
            this.lblRandevuTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMeslek.Location = new System.Drawing.Point(354, 215);
            this.lblMeslek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(81, 25);
            this.lblMeslek.TabIndex = 9;
            this.lblMeslek.Text = "Meslek:";
            this.lblMeslek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(347, 254);
            this.lblCinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(88, 25);
            this.lblCinsiyet.TabIndex = 10;
            this.lblCinsiyet.Text = "Cinsiyet:";
            this.lblCinsiyet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TelefonNo
            // 
            this.lbl_TelefonNo.AutoSize = true;
            this.lbl_TelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TelefonNo.Location = new System.Drawing.Point(321, 294);
            this.lbl_TelefonNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TelefonNo.Name = "lbl_TelefonNo";
            this.lbl_TelefonNo.Size = new System.Drawing.Size(114, 25);
            this.lbl_TelefonNo.TabIndex = 11;
            this.lbl_TelefonNo.Text = "Telefon No:";
            this.lbl_TelefonNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSikayet
            // 
            this.lblSikayet.AutoSize = true;
            this.lblSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSikayet.Location = new System.Drawing.Point(348, 333);
            this.lblSikayet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSikayet.Name = "lblSikayet";
            this.lblSikayet.Size = new System.Drawing.Size(87, 25);
            this.lblSikayet.TabIndex = 12;
            this.lblSikayet.Text = "Şikayeti:";
            this.lblSikayet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAlınanNot
            // 
            this.lblAlınanNot.AutoSize = true;
            this.lblAlınanNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlınanNot.Location = new System.Drawing.Point(366, 412);
            this.lblAlınanNot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlınanNot.Name = "lblAlınanNot";
            this.lblAlınanNot.Size = new System.Drawing.Size(69, 25);
            this.lblAlınanNot.TabIndex = 13;
            this.lblAlınanNot.Text = "Notlar:";
            this.lblAlınanNot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKullandigiIlaclar
            // 
            this.lblKullandigiIlaclar.AutoSize = true;
            this.lblKullandigiIlaclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullandigiIlaclar.Location = new System.Drawing.Point(276, 451);
            this.lblKullandigiIlaclar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullandigiIlaclar.Name = "lblKullandigiIlaclar";
            this.lblKullandigiIlaclar.Size = new System.Drawing.Size(159, 25);
            this.lblKullandigiIlaclar.TabIndex = 14;
            this.lblKullandigiIlaclar.Text = "Kullandığı İlaçlar:";
            this.lblKullandigiIlaclar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMeslek
            // 
            this.txtMeslek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMeslek.Location = new System.Drawing.Point(449, 215);
            this.txtMeslek.Margin = new System.Windows.Forms.Padding(4);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(355, 30);
            this.txtMeslek.TabIndex = 2;
            // 
            // txtAlınanNotlar
            // 
            this.txtAlınanNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlınanNotlar.Location = new System.Drawing.Point(449, 412);
            this.txtAlınanNotlar.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlınanNotlar.Name = "txtAlınanNotlar";
            this.txtAlınanNotlar.Size = new System.Drawing.Size(355, 30);
            this.txtAlınanNotlar.TabIndex = 16;
            // 
            // txtKullandigiIlaclar
            // 
            this.txtKullandigiIlaclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullandigiIlaclar.Location = new System.Drawing.Point(449, 451);
            this.txtKullandigiIlaclar.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullandigiIlaclar.Name = "txtKullandigiIlaclar";
            this.txtKullandigiIlaclar.Size = new System.Drawing.Size(355, 30);
            this.txtKullandigiIlaclar.TabIndex = 17;
            // 
            // txtSikayet
            // 
            this.txtSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSikayet.Location = new System.Drawing.Point(449, 333);
            this.txtSikayet.Margin = new System.Windows.Forms.Padding(4);
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(355, 30);
            this.txtSikayet.TabIndex = 18;
            // 
            // rbtErkek
            // 
            this.rbtErkek.AutoSize = true;
            this.rbtErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtErkek.Location = new System.Drawing.Point(449, 254);
            this.rbtErkek.Margin = new System.Windows.Forms.Padding(4);
            this.rbtErkek.Name = "rbtErkek";
            this.rbtErkek.Size = new System.Drawing.Size(83, 29);
            this.rbtErkek.TabIndex = 20;
            this.rbtErkek.TabStop = true;
            this.rbtErkek.Text = "Erkek";
            this.rbtErkek.UseVisualStyleBackColor = true;
            // 
            // rbtKadın
            // 
            this.rbtKadın.AutoSize = true;
            this.rbtKadın.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtKadın.Location = new System.Drawing.Point(547, 254);
            this.rbtKadın.Margin = new System.Windows.Forms.Padding(4);
            this.rbtKadın.Name = "rbtKadın";
            this.rbtKadın.Size = new System.Drawing.Size(84, 29);
            this.rbtKadın.TabIndex = 21;
            this.rbtKadın.TabStop = true;
            this.rbtKadın.Text = "Kadın";
            this.rbtKadın.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Location = new System.Drawing.Point(220, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 123);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(477, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(97, 43);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(275, 33);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Hasta Kaydı Oluştur";
            // 
            // chxOnay
            // 
            this.chxOnay.AutoSize = true;
            this.chxOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxOnay.Location = new System.Drawing.Point(521, 533);
            this.chxOnay.Margin = new System.Windows.Forms.Padding(4);
            this.chxOnay.Name = "chxOnay";
            this.chxOnay.Size = new System.Drawing.Size(144, 29);
            this.chxOnay.TabIndex = 24;
            this.chxOnay.Text = "Onaylıyorum";
            this.chxOnay.UseVisualStyleBackColor = true;
            this.chxOnay.CheckedChanged += new System.EventHandler(this.chxOnay_CheckedChanged);
            // 
            // cbxDoktor
            // 
            this.cbxDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDoktor.FormattingEnabled = true;
            this.cbxDoktor.Items.AddRange(new object[] {
            "Koray Acaroğlu",
            "Doktor 1",
            "Doktor 2",
            "Doktor 3"});
            this.cbxDoktor.Location = new System.Drawing.Point(449, 491);
            this.cbxDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDoktor.Name = "cbxDoktor";
            this.cbxDoktor.Size = new System.Drawing.Size(355, 33);
            this.cbxDoktor.TabIndex = 25;
            // 
            // lblDoktor
            // 
            this.lblDoktor.AutoSize = true;
            this.lblDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktor.Location = new System.Drawing.Point(241, 494);
            this.lblDoktor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoktor.Name = "lblDoktor";
            this.lblDoktor.Size = new System.Drawing.Size(194, 25);
            this.lblDoktor.TabIndex = 26;
            this.lblDoktor.Text = "Tercih Edilen Doktor:";
            this.lblDoktor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 794);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtSearchError);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.txtTelArama);
            this.tabPage3.Controls.Add(this.lblTelefonNmr);
            this.tabPage3.Controls.Add(this.lblRandevuTrh);
            this.tabPage3.Controls.Add(this.chxDetayliArama);
            this.tabPage3.Controls.Add(this.dtpArama);
            this.tabPage3.Controls.Add(this.btnAra);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtAra);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1105, 765);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Randevular";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblTelefonNmr
            // 
            this.lblTelefonNmr.AutoSize = true;
            this.lblTelefonNmr.Enabled = false;
            this.lblTelefonNmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonNmr.Location = new System.Drawing.Point(544, 266);
            this.lblTelefonNmr.Name = "lblTelefonNmr";
            this.lblTelefonNmr.Size = new System.Drawing.Size(120, 17);
            this.lblTelefonNmr.TabIndex = 37;
            this.lblTelefonNmr.Text = "Telefon Numarası";
            this.lblTelefonNmr.Visible = false;
            // 
            // lblRandevuTrh
            // 
            this.lblRandevuTrh.AutoSize = true;
            this.lblRandevuTrh.Enabled = false;
            this.lblRandevuTrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRandevuTrh.Location = new System.Drawing.Point(208, 266);
            this.lblRandevuTrh.Name = "lblRandevuTrh";
            this.lblRandevuTrh.Size = new System.Drawing.Size(105, 17);
            this.lblRandevuTrh.TabIndex = 35;
            this.lblRandevuTrh.Text = "Randevu Tarihi";
            this.lblRandevuTrh.Visible = false;
            // 
            // chxDetayliArama
            // 
            this.chxDetayliArama.AutoSize = true;
            this.chxDetayliArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chxDetayliArama.Location = new System.Drawing.Point(211, 231);
            this.chxDetayliArama.Name = "chxDetayliArama";
            this.chxDetayliArama.Size = new System.Drawing.Size(137, 24);
            this.chxDetayliArama.TabIndex = 34;
            this.chxDetayliArama.Text = "Detaylı Arama";
            this.chxDetayliArama.UseVisualStyleBackColor = true;
            this.chxDetayliArama.Click += new System.EventHandler(this.chxDetayliArama_Click);
            // 
            // dtpArama
            // 
            this.dtpArama.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpArama.CalendarTitleForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtpArama.CustomFormat = "dd/MM/yyyy HH:mm ";
            this.dtpArama.Enabled = false;
            this.dtpArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpArama.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArama.Location = new System.Drawing.Point(211, 286);
            this.dtpArama.Name = "dtpArama";
            this.dtpArama.Size = new System.Drawing.Size(275, 26);
            this.dtpArama.TabIndex = 33;
            this.dtpArama.Visible = false;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(863, 176);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(119, 30);
            this.btnAra.TabIndex = 32;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Randevu Ara";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAra.Location = new System.Drawing.Point(211, 176);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(622, 30);
            this.txtAra.TabIndex = 30;
            this.txtAra.Text = "İsim soyisim giriniz";
            this.txtAra.Enter += new System.EventHandler(this.txtAra_Enter);
            this.txtAra.Leave += new System.EventHandler(this.txtAra_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.İsimSoyisim,
            this.Meslek,
            this.Cinsiyet,
            this.TelefonNo,
            this.Şikayeti,
            this.RandevuTar,
            this.AlınanNotlar,
            this.Kullandığıİlaçlar,
            this.TercihEdilenDoktor});
            this.dataGridView1.Location = new System.Drawing.Point(23, 335);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 280);
            this.dataGridView1.TabIndex = 29;
            // 
            // İsimSoyisim
            // 
            this.İsimSoyisim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.İsimSoyisim.HeaderText = "İsimSoyisim";
            this.İsimSoyisim.MinimumWidth = 3;
            this.İsimSoyisim.Name = "İsimSoyisim";
            this.İsimSoyisim.ReadOnly = true;
            this.İsimSoyisim.Width = 108;
            // 
            // Meslek
            // 
            this.Meslek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Meslek.HeaderText = "Meslek";
            this.Meslek.MinimumWidth = 6;
            this.Meslek.Name = "Meslek";
            this.Meslek.ReadOnly = true;
            this.Meslek.Width = 80;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.MinimumWidth = 6;
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.ReadOnly = true;
            this.Cinsiyet.Width = 83;
            // 
            // TelefonNo
            // 
            this.TelefonNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TelefonNo.HeaderText = "TelefonNo";
            this.TelefonNo.MinimumWidth = 6;
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.ReadOnly = true;
            // 
            // Şikayeti
            // 
            this.Şikayeti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Şikayeti.HeaderText = "Şikayeti";
            this.Şikayeti.MinimumWidth = 6;
            this.Şikayeti.Name = "Şikayeti";
            this.Şikayeti.ReadOnly = true;
            this.Şikayeti.Width = 84;
            // 
            // RandevuTar
            // 
            this.RandevuTar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RandevuTar.HeaderText = "RandevuTar";
            this.RandevuTar.MinimumWidth = 6;
            this.RandevuTar.Name = "RandevuTar";
            this.RandevuTar.ReadOnly = true;
            this.RandevuTar.Width = 112;
            // 
            // AlınanNotlar
            // 
            this.AlınanNotlar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AlınanNotlar.HeaderText = "AlınanNotlar";
            this.AlınanNotlar.MinimumWidth = 6;
            this.AlınanNotlar.Name = "AlınanNotlar";
            this.AlınanNotlar.ReadOnly = true;
            this.AlınanNotlar.Width = 109;
            // 
            // Kullandığıİlaçlar
            // 
            this.Kullandığıİlaçlar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Kullandığıİlaçlar.HeaderText = "Kullandığıİlaçlar";
            this.Kullandığıİlaçlar.MinimumWidth = 6;
            this.Kullandığıİlaçlar.Name = "Kullandığıİlaçlar";
            this.Kullandığıİlaçlar.ReadOnly = true;
            this.Kullandığıİlaçlar.Width = 130;
            // 
            // TercihEdilenDoktor
            // 
            this.TercihEdilenDoktor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TercihEdilenDoktor.HeaderText = "TercihEdilenDoktor";
            this.TercihEdilenDoktor.MinimumWidth = 6;
            this.TercihEdilenDoktor.Name = "TercihEdilenDoktor";
            this.TercihEdilenDoktor.ReadOnly = true;
            this.TercihEdilenDoktor.Width = 152;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDocError);
            this.tabPage1.Controls.Add(this.txtTelError);
            this.tabPage1.Controls.Add(this.txtNameError);
            this.tabPage1.Controls.Add(this.txtTelefonNo);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lblDoktor);
            this.tabPage1.Controls.Add(this.lblMeslek);
            this.tabPage1.Controls.Add(this.txtIsimSoyisim);
            this.tabPage1.Controls.Add(this.txtSikayet);
            this.tabPage1.Controls.Add(this.lblRandevuTarihi);
            this.tabPage1.Controls.Add(this.cbxDoktor);
            this.tabPage1.Controls.Add(this.lblCinsiyet);
            this.tabPage1.Controls.Add(this.lblKullandigiIlaclar);
            this.tabPage1.Controls.Add(this.rbtErkek);
            this.tabPage1.Controls.Add(this.txtKullandigiIlaclar);
            this.tabPage1.Controls.Add(this.lblAlınanNot);
            this.tabPage1.Controls.Add(this.lblIsimSoyisim);
            this.tabPage1.Controls.Add(this.chxOnay);
            this.tabPage1.Controls.Add(this.lbl_TelefonNo);
            this.tabPage1.Controls.Add(this.txtMeslek);
            this.tabPage1.Controls.Add(this.rbtKadın);
            this.tabPage1.Controls.Add(this.btnKaydiTamamla);
            this.tabPage1.Controls.Add(this.txtAlınanNotlar);
            this.tabPage1.Controls.Add(this.lblSikayet);
            this.tabPage1.Controls.Add(this.dtpRandevuTarihi);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1105, 765);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Randevu Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.txtImplantID);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.lblIslemID);
            this.tabPage2.Controls.Add(this.txtHastaID);
            this.tabPage2.Controls.Add(this.txtUygulananNokta);
            this.tabPage2.Controls.Add(this.lblUygulananNokta);
            this.tabPage2.Controls.Add(this.lblIslemTarihi);
            this.tabPage2.Controls.Add(this.lsbIslemBilgileri);
            this.tabPage2.Controls.Add(this.lblHastaID);
            this.tabPage2.Controls.Add(this.lblIslemAdedi);
            this.tabPage2.Controls.Add(this.txtIslemID);
            this.tabPage2.Controls.Add(this.btnKayitEkle);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dtpIslemTarihi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1105, 765);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İşlem Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(430, 296);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(355, 30);
            this.numericUpDown1.TabIndex = 49;
            // 
            // txtImplantID
            // 
            this.txtImplantID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtImplantID.Location = new System.Drawing.Point(430, 333);
            this.txtImplantID.Margin = new System.Windows.Forms.Padding(4);
            this.txtImplantID.Name = "txtImplantID";
            this.txtImplantID.Size = new System.Drawing.Size(355, 30);
            this.txtImplantID.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(220, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 123);
            this.panel2.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(477, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geçmişe Kayıt Ekle";
            // 
            // lblIslemID
            // 
            this.lblIslemID.AutoSize = true;
            this.lblIslemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemID.Location = new System.Drawing.Point(326, 220);
            this.lblIslemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemID.Name = "lblIslemID";
            this.lblIslemID.Size = new System.Drawing.Size(88, 25);
            this.lblIslemID.TabIndex = 36;
            this.lblIslemID.Text = "İşlem ID:";
            this.lblIslemID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHastaID
            // 
            this.txtHastaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaID.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtHastaID.Location = new System.Drawing.Point(430, 176);
            this.txtHastaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtHastaID.Name = "txtHastaID";
            this.txtHastaID.Size = new System.Drawing.Size(355, 30);
            this.txtHastaID.TabIndex = 28;
            // 
            // txtUygulananNokta
            // 
            this.txtUygulananNokta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUygulananNokta.Location = new System.Drawing.Point(430, 373);
            this.txtUygulananNokta.Margin = new System.Windows.Forms.Padding(4);
            this.txtUygulananNokta.Name = "txtUygulananNokta";
            this.txtUygulananNokta.Size = new System.Drawing.Size(355, 30);
            this.txtUygulananNokta.TabIndex = 44;
            // 
            // lblUygulananNokta
            // 
            this.lblUygulananNokta.AutoSize = true;
            this.lblUygulananNokta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUygulananNokta.Location = new System.Drawing.Point(246, 378);
            this.lblUygulananNokta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUygulananNokta.Name = "lblUygulananNokta";
            this.lblUygulananNokta.Size = new System.Drawing.Size(168, 25);
            this.lblUygulananNokta.TabIndex = 35;
            this.lblUygulananNokta.Text = "Uygulanan Nokta:";
            this.lblUygulananNokta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIslemTarihi
            // 
            this.lblIslemTarihi.AutoSize = true;
            this.lblIslemTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemTarihi.Location = new System.Drawing.Point(296, 259);
            this.lblIslemTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemTarihi.Name = "lblIslemTarihi";
            this.lblIslemTarihi.Size = new System.Drawing.Size(118, 25);
            this.lblIslemTarihi.TabIndex = 37;
            this.lblIslemTarihi.Text = "İşlem Tarihi:";
            this.lblIslemTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lsbIslemBilgileri
            // 
            this.lsbIslemBilgileri.FormattingEnabled = true;
            this.lsbIslemBilgileri.ItemHeight = 16;
            this.lsbIslemBilgileri.Items.AddRange(new object[] {
            "ISLEM_ID        ISLEM_ADI",
            "      1\t  KANAL TEDAVİSİ\t",
            "      2\t  DOLGU",
            "      4\t  KÖPRÜ",
            "      5\t  ZİRKON KAPLAMA",
            "      6\t  AMALGAM KAPLAMA",
            "     10\t  IMPLANT ",
            "     11    \t  DİŞ ÇEKİMİ",
            "     12   \t  GÖMÜLÜ DİŞ AMELİYATI",
            "     13  \t  DİŞ TAŞI TEMİZLİĞİ",
            "     14  \t  TAM PROTEZ",
            "     15  \t  BÖLÜMLÜ PROTEZ(METAL)",
            "     16  \t  PROTEZ TAMİRİ",
            "     17  \t  DİŞ İLAVESİ",
            "     18    \t  APİKAL REZEKSİYON",
            "     19  \t  KİST OPERASYONU",
            "     20  \t  VESTİBÜLOPLASTİ"});
            this.lsbIslemBilgileri.Location = new System.Drawing.Point(430, 449);
            this.lsbIslemBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.lsbIslemBilgileri.Name = "lsbIslemBilgileri";
            this.lsbIslemBilgileri.Size = new System.Drawing.Size(264, 292);
            this.lsbIslemBilgileri.TabIndex = 30;
            this.lsbIslemBilgileri.SelectedIndexChanged += new System.EventHandler(this.lsbIslemBilgileri_SelectedIndexChanged);
            // 
            // lblHastaID
            // 
            this.lblHastaID.AutoSize = true;
            this.lblHastaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaID.Location = new System.Drawing.Point(321, 179);
            this.lblHastaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHastaID.Name = "lblHastaID";
            this.lblHastaID.Size = new System.Drawing.Size(93, 25);
            this.lblHastaID.TabIndex = 34;
            this.lblHastaID.Text = "Hasta ID:";
            this.lblHastaID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIslemAdedi
            // 
            this.lblIslemAdedi.AutoSize = true;
            this.lblIslemAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemAdedi.Location = new System.Drawing.Point(294, 301);
            this.lblIslemAdedi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemAdedi.Name = "lblIslemAdedi";
            this.lblIslemAdedi.Size = new System.Drawing.Size(120, 25);
            this.lblIslemAdedi.TabIndex = 38;
            this.lblIslemAdedi.Text = "İşlem Adedi:";
            this.lblIslemAdedi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIslemID
            // 
            this.txtIslemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemID.Location = new System.Drawing.Point(430, 215);
            this.txtIslemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtIslemID.Name = "txtIslemID";
            this.txtIslemID.Size = new System.Drawing.Size(355, 30);
            this.txtIslemID.TabIndex = 29;
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Location = new System.Drawing.Point(662, 412);
            this.btnKayitEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(124, 30);
            this.btnKayitEkle.TabIndex = 32;
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(309, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "İmplant ID:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpIslemTarihi
            // 
            this.dtpIslemTarihi.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpIslemTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpIslemTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIslemTarihi.Location = new System.Drawing.Point(430, 254);
            this.dtpIslemTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpIslemTarihi.Name = "dtpIslemTarihi";
            this.dtpIslemTarihi.Size = new System.Drawing.Size(355, 30);
            this.dtpIslemTarihi.TabIndex = 33;
            this.dtpIslemTarihi.Value = new System.DateTime(2022, 5, 14, 0, 0, 0, 0);
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefonNo.Location = new System.Drawing.Point(449, 294);
            this.txtTelefonNo.Mask = "999 000 00 00";
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(355, 30);
            this.txtTelefonNo.TabIndex = 27;
            // 
            // txtTelArama
            // 
            this.txtTelArama.Enabled = false;
            this.txtTelArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelArama.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTelArama.Location = new System.Drawing.Point(547, 286);
            this.txtTelArama.Mask = "999 000 00 00";
            this.txtTelArama.Name = "txtTelArama";
            this.txtTelArama.Size = new System.Drawing.Size(286, 26);
            this.txtTelArama.TabIndex = 39;
            this.txtTelArama.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(220, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 123);
            this.panel3.TabIndex = 48;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(477, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(207, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(172, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Randevular";
            // 
            // txtSearchError
            // 
            this.txtSearchError.AutoSize = true;
            this.txtSearchError.ForeColor = System.Drawing.Color.IndianRed;
            this.txtSearchError.Location = new System.Drawing.Point(215, 209);
            this.txtSearchError.Name = "txtSearchError";
            this.txtSearchError.Size = new System.Drawing.Size(209, 16);
            this.txtSearchError.TabIndex = 49;
            this.txtSearchError.Text = "Bu alanın doldurulması zorunludur!";
            this.txtSearchError.Visible = false;
            // 
            // txtNameError
            // 
            this.txtNameError.AutoSize = true;
            this.txtNameError.ForeColor = System.Drawing.Color.IndianRed;
            this.txtNameError.Location = new System.Drawing.Point(811, 183);
            this.txtNameError.Name = "txtNameError";
            this.txtNameError.Size = new System.Drawing.Size(209, 16);
            this.txtNameError.TabIndex = 50;
            this.txtNameError.Text = "Bu alanın doldurulması zorunludur!";
            this.txtNameError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNameError.Visible = false;
            // 
            // txtTelError
            // 
            this.txtTelError.AutoSize = true;
            this.txtTelError.ForeColor = System.Drawing.Color.IndianRed;
            this.txtTelError.Location = new System.Drawing.Point(811, 301);
            this.txtTelError.Name = "txtTelError";
            this.txtTelError.Size = new System.Drawing.Size(245, 16);
            this.txtTelError.TabIndex = 51;
            this.txtTelError.Text = "Lütfen geçerli bir telefon numarası giriniz!";
            this.txtTelError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTelError.Visible = false;
            // 
            // txtDocError
            // 
            this.txtDocError.AutoSize = true;
            this.txtDocError.ForeColor = System.Drawing.Color.IndianRed;
            this.txtDocError.Location = new System.Drawing.Point(811, 501);
            this.txtDocError.Name = "txtDocError";
            this.txtDocError.Size = new System.Drawing.Size(209, 16);
            this.txtDocError.TabIndex = 53;
            this.txtDocError.Text = "Bu alanın doldurulması zorunludur!";
            this.txtDocError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDocError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 788);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtIsimSoyisim;
        private System.Windows.Forms.Button btnKaydiTamamla;
        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private System.Windows.Forms.Label lblIsimSoyisim;
        private System.Windows.Forms.Label lblRandevuTarihi;
        private System.Windows.Forms.Label lblMeslek;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lbl_TelefonNo;
        private System.Windows.Forms.Label lblSikayet;
        private System.Windows.Forms.Label lblAlınanNot;
        private System.Windows.Forms.Label lblKullandigiIlaclar;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.TextBox txtAlınanNotlar;
        private System.Windows.Forms.TextBox txtKullandigiIlaclar;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.RadioButton rbtErkek;
        private System.Windows.Forms.RadioButton rbtKadın;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.CheckBox chxOnay;
        private System.Windows.Forms.ComboBox cbxDoktor;
        private System.Windows.Forms.Label lblDoktor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIslemID;
        private System.Windows.Forms.TextBox txtHastaID;
        private System.Windows.Forms.TextBox txtUygulananNokta;
        private System.Windows.Forms.Label lblUygulananNokta;
        private System.Windows.Forms.Label lblIslemTarihi;
        private System.Windows.Forms.ListBox lsbIslemBilgileri;
        private System.Windows.Forms.Label lblHastaID;
        private System.Windows.Forms.Label lblIslemAdedi;
        private System.Windows.Forms.TextBox txtIslemID;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpIslemTarihi;
        private System.Windows.Forms.TextBox txtImplantID;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn İsimSoyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meslek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Şikayeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuTar;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlınanNotlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kullandığıİlaçlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TercihEdilenDoktor;
        private System.Windows.Forms.CheckBox chxDetayliArama;
        private System.Windows.Forms.DateTimePicker dtpArama;
        private System.Windows.Forms.Label lblTelefonNmr;
        private System.Windows.Forms.Label lblRandevuTrh;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MaskedTextBox txtTelefonNo;
        private System.Windows.Forms.MaskedTextBox txtTelArama;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtSearchError;
        private System.Windows.Forms.Label txtNameError;
        private System.Windows.Forms.Label txtDocError;
        private System.Windows.Forms.Label txtTelError;
    }
}

