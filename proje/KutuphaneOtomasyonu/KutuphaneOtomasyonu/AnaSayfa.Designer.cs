namespace KutuphaneOtomasyonu
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetIade = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnSıralama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnUyeEkle);
            this.groupBox1.Controls.Add(this.btnUyeListele);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(451, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uye Islemleri";
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnUyeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeEkle.ForeColor = System.Drawing.Color.White;
            this.btnUyeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeEkle.ImageIndex = 0;
            this.btnUyeEkle.ImageList = this.ımageList2;
            this.btnUyeEkle.Location = new System.Drawing.Point(28, 27);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(326, 34);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Uye Ekleme Islemleri";
            this.btnUyeEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUyeEkle.UseVisualStyleBackColor = false;
            this.btnUyeEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "images.png");
            this.ımageList2.Images.SetKeyName(1, "indir.png");
            this.ımageList2.Images.SetKeyName(2, "indir (2).png");
            this.ımageList2.Images.SetKeyName(3, "indir (1).png");
            this.ımageList2.Images.SetKeyName(4, "indir (3).png");
            this.ımageList2.Images.SetKeyName(5, "indir (5).png");
            this.ımageList2.Images.SetKeyName(6, "indir (4).png");
            this.ımageList2.Images.SetKeyName(7, "indir (6).png");
            this.ımageList2.Images.SetKeyName(8, "indir (7).png");
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeListele.ForeColor = System.Drawing.Color.White;
            this.btnUyeListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeListele.ImageIndex = 1;
            this.btnUyeListele.ImageList = this.ımageList2;
            this.btnUyeListele.Location = new System.Drawing.Point(28, 84);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(326, 34);
            this.btnUyeListele.TabIndex = 1;
            this.btnUyeListele.Text = "Uye Listeleme Islemleri";
            this.btnUyeListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUyeListele.UseVisualStyleBackColor = true;
            this.btnUyeListele.Click += new System.EventHandler(this.btnUyeListele_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnKitapListele);
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1084, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Islemleri";
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapListele.ForeColor = System.Drawing.Color.White;
            this.btnKitapListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapListele.ImageIndex = 3;
            this.btnKitapListele.ImageList = this.ımageList2;
            this.btnKitapListele.Location = new System.Drawing.Point(33, 84);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(325, 34);
            this.btnKitapListele.TabIndex = 1;
            this.btnKitapListele.Text = "Kitap Listeleme Islemleri";
            this.btnKitapListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapEkle.ForeColor = System.Drawing.Color.White;
            this.btnKitapEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapEkle.ImageIndex = 2;
            this.btnKitapEkle.ImageList = this.ımageList2;
            this.btnKitapEkle.Location = new System.Drawing.Point(33, 27);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(325, 34);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekleme Islemleri";
            this.btnKitapEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnEmanetIade);
            this.groupBox3.Controls.Add(this.btnEmanetListele);
            this.groupBox3.Controls.Add(this.btnEmanetVer);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(451, 500);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap Islemleri";
            // 
            // btnEmanetIade
            // 
            this.btnEmanetIade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetIade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetIade.ImageIndex = 5;
            this.btnEmanetIade.ImageList = this.ımageList2;
            this.btnEmanetIade.Location = new System.Drawing.Point(28, 143);
            this.btnEmanetIade.Name = "btnEmanetIade";
            this.btnEmanetIade.Size = new System.Drawing.Size(432, 38);
            this.btnEmanetIade.TabIndex = 2;
            this.btnEmanetIade.Text = "Emanet Kitap Iade Islemleri";
            this.btnEmanetIade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmanetIade.UseVisualStyleBackColor = true;
            this.btnEmanetIade.Click += new System.EventHandler(this.btnEmanetIade_Click);
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetListele.ImageIndex = 6;
            this.btnEmanetListele.ImageList = this.ımageList2;
            this.btnEmanetListele.Location = new System.Drawing.Point(28, 82);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(432, 38);
            this.btnEmanetListele.TabIndex = 1;
            this.btnEmanetListele.Text = "Emanet Kitap Listeleme Islemleri";
            this.btnEmanetListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmanetListele.UseVisualStyleBackColor = true;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetVer.ImageIndex = 4;
            this.btnEmanetVer.ImageList = this.ımageList2;
            this.btnEmanetVer.Location = new System.Drawing.Point(28, 27);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(432, 38);
            this.btnEmanetVer.TabIndex = 0;
            this.btnEmanetVer.Text = "Emanet Kitap Verme Islemleri";
            this.btnEmanetVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmanetVer.UseVisualStyleBackColor = true;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnGrafik);
            this.groupBox4.Controls.Add(this.btnSıralama);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1084, 547);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 134);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve Grafikler";
            // 
            // btnGrafik
            // 
            this.btnGrafik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrafik.ImageIndex = 8;
            this.btnGrafik.ImageList = this.ımageList2;
            this.btnGrafik.Location = new System.Drawing.Point(33, 90);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(325, 38);
            this.btnGrafik.TabIndex = 1;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnSıralama
            // 
            this.btnSıralama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSıralama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSıralama.ImageIndex = 7;
            this.btnSıralama.ImageList = this.ımageList2;
            this.btnSıralama.Location = new System.Drawing.Point(33, 26);
            this.btnSıralama.Name = "btnSıralama";
            this.btnSıralama.Size = new System.Drawing.Size(325, 38);
            this.btnSıralama.TabIndex = 0;
            this.btnSıralama.Text = "Sıralama";
            this.btnSıralama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSıralama.UseVisualStyleBackColor = true;
            this.btnSıralama.Click += new System.EventHandler(this.btnSıralama_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::KutuphaneOtomasyonu.Properties.Resources.kutuphane4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1465, 774);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEmanetIade;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnSıralama;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

