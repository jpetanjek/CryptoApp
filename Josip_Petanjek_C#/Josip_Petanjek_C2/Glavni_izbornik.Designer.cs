namespace Josip_Petanjek_C2
{
    partial class Glavni_izbornik
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavni_izbornik));
            this.Input_provjeri = new System.Windows.Forms.Button();
            this.Input_digitalni = new System.Windows.Forms.Button();
            this.Input_sazetak = new System.Windows.Forms.Button();
            this.Input_RSA_dekrip = new System.Windows.Forms.Button();
            this.Input_AES_dekrip = new System.Windows.Forms.Button();
            this.Input_RSA_krip = new System.Windows.Forms.Button();
            this.Input_AES_krip = new System.Windows.Forms.Button();
            this.Output_kriptiranje = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Input_teksta = new System.Windows.Forms.TextBox();
            this.Input_datoteke = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label_PK = new System.Windows.Forms.Label();
            this.Label_JK = new System.Windows.Forms.Label();
            this.Label_TK = new System.Windows.Forms.Label();
            this.Label_dir = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Input_direktorija = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Input_provjeri
            // 
            this.Input_provjeri.Enabled = false;
            this.Input_provjeri.Location = new System.Drawing.Point(279, 542);
            this.Input_provjeri.Name = "Input_provjeri";
            this.Input_provjeri.Size = new System.Drawing.Size(116, 23);
            this.Input_provjeri.TabIndex = 43;
            this.Input_provjeri.Text = "Provjeri potpis";
            this.Input_provjeri.UseVisualStyleBackColor = true;
            this.Input_provjeri.Click += new System.EventHandler(this.Input_provjeri_Click);
            // 
            // Input_digitalni
            // 
            this.Input_digitalni.Enabled = false;
            this.Input_digitalni.Location = new System.Drawing.Point(157, 542);
            this.Input_digitalni.Name = "Input_digitalni";
            this.Input_digitalni.Size = new System.Drawing.Size(116, 23);
            this.Input_digitalni.TabIndex = 42;
            this.Input_digitalni.Text = "Digitalno potpiši";
            this.toolTip1.SetToolTip(this.Input_digitalni, "SHA256");
            this.Input_digitalni.UseVisualStyleBackColor = true;
            this.Input_digitalni.Click += new System.EventHandler(this.Input_digitalni_Click);
            // 
            // Input_sazetak
            // 
            this.Input_sazetak.Enabled = false;
            this.Input_sazetak.Location = new System.Drawing.Point(35, 542);
            this.Input_sazetak.Name = "Input_sazetak";
            this.Input_sazetak.Size = new System.Drawing.Size(116, 23);
            this.Input_sazetak.TabIndex = 41;
            this.Input_sazetak.Text = "Izračunaj sažetak";
            this.Input_sazetak.UseVisualStyleBackColor = true;
            this.Input_sazetak.Click += new System.EventHandler(this.Input_sazetak_Click);
            // 
            // Input_RSA_dekrip
            // 
            this.Input_RSA_dekrip.Enabled = false;
            this.Input_RSA_dekrip.Location = new System.Drawing.Point(401, 412);
            this.Input_RSA_dekrip.Name = "Input_RSA_dekrip";
            this.Input_RSA_dekrip.Size = new System.Drawing.Size(116, 23);
            this.Input_RSA_dekrip.TabIndex = 40;
            this.Input_RSA_dekrip.Text = "RSA dekriptiranje";
            this.Input_RSA_dekrip.UseVisualStyleBackColor = true;
            this.Input_RSA_dekrip.Click += new System.EventHandler(this.Input_RSA_dekrip_Click);
            // 
            // Input_AES_dekrip
            // 
            this.Input_AES_dekrip.Enabled = false;
            this.Input_AES_dekrip.Location = new System.Drawing.Point(279, 412);
            this.Input_AES_dekrip.Name = "Input_AES_dekrip";
            this.Input_AES_dekrip.Size = new System.Drawing.Size(116, 23);
            this.Input_AES_dekrip.TabIndex = 39;
            this.Input_AES_dekrip.Text = "AES dekriptiranje";
            this.Input_AES_dekrip.UseVisualStyleBackColor = true;
            this.Input_AES_dekrip.Click += new System.EventHandler(this.Input_AES_dekrip_Click);
            // 
            // Input_RSA_krip
            // 
            this.Input_RSA_krip.Enabled = false;
            this.Input_RSA_krip.Location = new System.Drawing.Point(157, 412);
            this.Input_RSA_krip.Name = "Input_RSA_krip";
            this.Input_RSA_krip.Size = new System.Drawing.Size(116, 23);
            this.Input_RSA_krip.TabIndex = 38;
            this.Input_RSA_krip.Text = "RSA kriptiranje";
            this.Input_RSA_krip.UseVisualStyleBackColor = true;
            this.Input_RSA_krip.Click += new System.EventHandler(this.Input_RES_krip_Click);
            // 
            // Input_AES_krip
            // 
            this.Input_AES_krip.Enabled = false;
            this.Input_AES_krip.Location = new System.Drawing.Point(35, 412);
            this.Input_AES_krip.Name = "Input_AES_krip";
            this.Input_AES_krip.Size = new System.Drawing.Size(116, 23);
            this.Input_AES_krip.TabIndex = 37;
            this.Input_AES_krip.Text = "AES kriptiranje";
            this.Input_AES_krip.UseVisualStyleBackColor = true;
            this.Input_AES_krip.Click += new System.EventHandler(this.Input_AES_krip_Click);
            // 
            // Output_kriptiranje
            // 
            this.Output_kriptiranje.Enabled = false;
            this.Output_kriptiranje.Location = new System.Drawing.Point(35, 442);
            this.Output_kriptiranje.Multiline = true;
            this.Output_kriptiranje.Name = "Output_kriptiranje";
            this.Output_kriptiranje.Size = new System.Drawing.Size(482, 94);
            this.Output_kriptiranje.TabIndex = 36;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(12, 385);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(339, 24);
            this.Label7.TabIndex = 35;
            this.Label7.Text = "3. Odaberi način kriptiranja/dekriptiranja";
            // 
            // Input_teksta
            // 
            this.Input_teksta.Enabled = false;
            this.Input_teksta.Location = new System.Drawing.Point(38, 270);
            this.Input_teksta.Multiline = true;
            this.Input_teksta.Name = "Input_teksta";
            this.Input_teksta.Size = new System.Drawing.Size(479, 94);
            this.Input_teksta.TabIndex = 34;
            this.Input_teksta.TextChanged += new System.EventHandler(this.Input_teksta_TextChanged);
            // 
            // Input_datoteke
            // 
            this.Input_datoteke.Enabled = false;
            this.Input_datoteke.Location = new System.Drawing.Point(38, 241);
            this.Input_datoteke.Name = "Input_datoteke";
            this.Input_datoteke.Size = new System.Drawing.Size(116, 23);
            this.Input_datoteke.TabIndex = 33;
            this.Input_datoteke.Text = "Odaberi datoteku";
            this.Input_datoteke.UseVisualStyleBackColor = true;
            this.Input_datoteke.Click += new System.EventHandler(this.Input_datoteke_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(12, 214);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(505, 24);
            this.Label6.TabIndex = 32;
            this.Label6.Text = "2. Odaberi datoteku za kriptiranje/dekriptiranje ili unesi tekst:";
            // 
            // Label_PK
            // 
            this.Label_PK.AutoSize = true;
            this.Label_PK.Location = new System.Drawing.Point(162, 186);
            this.Label_PK.Name = "Label_PK";
            this.Label_PK.Size = new System.Drawing.Size(115, 13);
            this.Label_PK.TabIndex = 31;
            this.Label_PK.Text = "Ključevi nisu generirani";
            // 
            // Label_JK
            // 
            this.Label_JK.AutoSize = true;
            this.Label_JK.Location = new System.Drawing.Point(162, 173);
            this.Label_JK.Name = "Label_JK";
            this.Label_JK.Size = new System.Drawing.Size(115, 13);
            this.Label_JK.TabIndex = 30;
            this.Label_JK.Text = "Ključevi nisu generirani";
            // 
            // Label_TK
            // 
            this.Label_TK.AutoSize = true;
            this.Label_TK.Location = new System.Drawing.Point(162, 160);
            this.Label_TK.Name = "Label_TK";
            this.Label_TK.Size = new System.Drawing.Size(115, 13);
            this.Label_TK.TabIndex = 29;
            this.Label_TK.Text = "Ključevi nisu generirani";
            // 
            // Label_dir
            // 
            this.Label_dir.AutoSize = true;
            this.Label_dir.Location = new System.Drawing.Point(267, 102);
            this.Label_dir.Name = "Label_dir";
            this.Label_dir.Size = new System.Drawing.Size(107, 13);
            this.Label_dir.TabIndex = 28;
            this.Label_dir.Text = "direktorij nije odabran";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(65, 186);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(101, 13);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "RSA - Privatni ključ:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(65, 173);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(91, 13);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "RSA - Javni ključ:";
            this.toolTip1.SetToolTip(this.Label4, "Asimetričan algoritam - enkripcija javni, dekripcija privatni , ključevi 2048 ");
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(65, 160);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 13);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "AES - Tajni ključ:";
            this.toolTip1.SetToolTip(this.Label3, "Simetričan algoritam - isti ključ za enkripciju i dekripciju, veličina bloka 128," +
        " ključa 256");
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(35, 147);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 13);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Generirani ključevi:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 94);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(249, 24);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "1. Odaberi direktorij projekta:";
            // 
            // Input_direktorija
            // 
            this.Input_direktorija.Location = new System.Drawing.Point(35, 121);
            this.Input_direktorija.Name = "Input_direktorija";
            this.Input_direktorija.Size = new System.Drawing.Size(116, 23);
            this.Input_direktorija.TabIndex = 22;
            this.Input_direktorija.Text = "Odaberi direktorij";
            this.Input_direktorija.UseVisualStyleBackColor = true;
            this.Input_direktorija.Click += new System.EventHandler(this.Input_direktorija_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(1, -54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 145);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(327, -84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 119);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-70, 576);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(771, 18);
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Glavni_izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(532, 587);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Input_provjeri);
            this.Controls.Add(this.Input_digitalni);
            this.Controls.Add(this.Input_sazetak);
            this.Controls.Add(this.Input_RSA_dekrip);
            this.Controls.Add(this.Input_AES_dekrip);
            this.Controls.Add(this.Input_RSA_krip);
            this.Controls.Add(this.Input_AES_krip);
            this.Controls.Add(this.Output_kriptiranje);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Input_teksta);
            this.Controls.Add(this.Input_datoteke);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label_PK);
            this.Controls.Add(this.Label_JK);
            this.Controls.Add(this.Label_TK);
            this.Controls.Add(this.Label_dir);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Input_direktorija);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Glavni_izbornik";
            this.Text = "CryptoApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavni_izbornik_FormClosed);
            this.Load += new System.EventHandler(this.Glavni_izbornik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Input_provjeri;
        internal System.Windows.Forms.Button Input_digitalni;
        internal System.Windows.Forms.Button Input_sazetak;
        internal System.Windows.Forms.Button Input_RSA_dekrip;
        internal System.Windows.Forms.Button Input_AES_dekrip;
        internal System.Windows.Forms.Button Input_RSA_krip;
        internal System.Windows.Forms.Button Input_AES_krip;
        internal System.Windows.Forms.TextBox Output_kriptiranje;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox Input_teksta;
        internal System.Windows.Forms.Button Input_datoteke;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label_PK;
        internal System.Windows.Forms.Label Label_JK;
        internal System.Windows.Forms.Label Label_TK;
        internal System.Windows.Forms.Label Label_dir;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Input_direktorija;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

