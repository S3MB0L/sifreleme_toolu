namespace Sifreleme_Toolu
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtDirPath = new System.Windows.Forms.TextBox();
            this.Dosya_Gozat = new System.Windows.Forms.Button();
            this.Klasor_Gozat = new System.Windows.Forms.Button();
            this.encMethod = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sifrele = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klasörSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifrelenenİçerikleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriTabanıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarıYönetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Klasör Seç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifreleme Metodu";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(80, 36);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(100, 20);
            this.txtFilePath.TabIndex = 5;
            // 
            // txtDirPath
            // 
            this.txtDirPath.Location = new System.Drawing.Point(81, 70);
            this.txtDirPath.Name = "txtDirPath";
            this.txtDirPath.Size = new System.Drawing.Size(100, 20);
            this.txtDirPath.TabIndex = 6;
            // 
            // Dosya_Gozat
            // 
            this.Dosya_Gozat.Location = new System.Drawing.Point(186, 34);
            this.Dosya_Gozat.Name = "Dosya_Gozat";
            this.Dosya_Gozat.Size = new System.Drawing.Size(55, 23);
            this.Dosya_Gozat.TabIndex = 10;
            this.Dosya_Gozat.Text = "Gözat";
            this.Dosya_Gozat.UseVisualStyleBackColor = true;
            this.Dosya_Gozat.Click += new System.EventHandler(this.Dosya_Gozat_Click);
            // 
            // Klasor_Gozat
            // 
            this.Klasor_Gozat.Location = new System.Drawing.Point(186, 70);
            this.Klasor_Gozat.Name = "Klasor_Gozat";
            this.Klasor_Gozat.Size = new System.Drawing.Size(56, 23);
            this.Klasor_Gozat.TabIndex = 11;
            this.Klasor_Gozat.Text = "Gözat";
            this.Klasor_Gozat.UseVisualStyleBackColor = true;
            this.Klasor_Gozat.Click += new System.EventHandler(this.Klasor_Gozat_Click);
            // 
            // encMethod
            // 
            this.encMethod.FormattingEnabled = true;
            this.encMethod.Items.AddRange(new object[] {
            "AES",
            "RSA",
            "SHA",
            "SHA_256"});
            this.encMethod.Location = new System.Drawing.Point(341, 35);
            this.encMethod.Name = "encMethod";
            this.encMethod.Size = new System.Drawing.Size(85, 21);
            this.encMethod.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 305);
            this.dataGridView1.TabIndex = 13;
            // 
            // sifrele
            // 
            this.sifrele.Location = new System.Drawing.Point(347, 70);
            this.sifrele.Name = "sifrele";
            this.sifrele.Size = new System.Drawing.Size(55, 23);
            this.sifrele.TabIndex = 14;
            this.sifrele.Text = "Şifrele";
            this.sifrele.UseVisualStyleBackColor = true;
            this.sifrele.Click += new System.EventHandler(this.sifrele_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(600, 70);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(85, 23);
            this.btn_logout.TabIndex = 15;
            this.btn_logout.Text = "Güvenli Çıkış";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Dosyaları Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.veriTabanıToolStripMenuItem,
            this.yönetimToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaSeçToolStripMenuItem,
            this.klasörSeçToolStripMenuItem,
            this.şifrelenenİçerikleriListeleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "Dosya";
            // 
            // dosyaSeçToolStripMenuItem
            // 
            this.dosyaSeçToolStripMenuItem.Name = "dosyaSeçToolStripMenuItem";
            this.dosyaSeçToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.dosyaSeçToolStripMenuItem.Text = "Dosya Seç";
            this.dosyaSeçToolStripMenuItem.Click += new System.EventHandler(this.dosyaSeçToolStripMenuItem_Click);
            // 
            // klasörSeçToolStripMenuItem
            // 
            this.klasörSeçToolStripMenuItem.Name = "klasörSeçToolStripMenuItem";
            this.klasörSeçToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.klasörSeçToolStripMenuItem.Text = "Klasör Seç";
            this.klasörSeçToolStripMenuItem.Click += new System.EventHandler(this.klasörSeçToolStripMenuItem_Click);
            // 
            // şifrelenenİçerikleriListeleToolStripMenuItem
            // 
            this.şifrelenenİçerikleriListeleToolStripMenuItem.Name = "şifrelenenİçerikleriListeleToolStripMenuItem";
            this.şifrelenenİçerikleriListeleToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.şifrelenenİçerikleriListeleToolStripMenuItem.Text = "Şifrelenen İçerikleri Listele";
            this.şifrelenenİçerikleriListeleToolStripMenuItem.Click += new System.EventHandler(this.şifrelenenİçerikleriListeleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // veriTabanıToolStripMenuItem
            // 
            this.veriTabanıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeleToolStripMenuItem});
            this.veriTabanıToolStripMenuItem.Name = "veriTabanıToolStripMenuItem";
            this.veriTabanıToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.veriTabanıToolStripMenuItem.Text = "Veri Tabanı";
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.listeleToolStripMenuItem.Text = "Listele";
            // 
            // yönetimToolStripMenuItem
            // 
            this.yönetimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarıYönetToolStripMenuItem});
            this.yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            this.yönetimToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.yönetimToolStripMenuItem.Text = "Yönetim";
            // 
            // kullanıcılarıYönetToolStripMenuItem
            // 
            this.kullanıcılarıYönetToolStripMenuItem.Name = "kullanıcılarıYönetToolStripMenuItem";
            this.kullanıcılarıYönetToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.kullanıcılarıYönetToolStripMenuItem.Text = "Kullanıcıları Yönet";
            this.kullanıcılarıYönetToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarıYönetToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Aktif Kullanıcı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "UID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Yetki";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(590, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "label9";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(527, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Key\'i Seç/Kaydet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Şifreyi Çöz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(630, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Gözat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(441, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "F-ID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 434);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.sifrele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.encMethod);
            this.Controls.Add(this.Klasor_Gozat);
            this.Controls.Add(this.Dosya_Gozat);
            this.Controls.Add(this.txtDirPath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtDirPath;
        private System.Windows.Forms.Button Dosya_Gozat;
        private System.Windows.Forms.Button Klasor_Gozat;
        private System.Windows.Forms.ComboBox encMethod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sifrele;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klasörSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifrelenenİçerikleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriTabanıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarıYönetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
    }
}