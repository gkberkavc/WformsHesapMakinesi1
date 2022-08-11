namespace WformsHesapMakinesi1
{
    partial class Form1
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
            this.btnParantezAc = new System.Windows.Forms.Button();
            this.btnParantezKapat = new System.Windows.Forms.Button();
            this.btnYuzde = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnYedi = new System.Windows.Forms.Button();
            this.btnSekiz = new System.Windows.Forms.Button();
            this.btnDokuz = new System.Windows.Forms.Button();
            this.btnBölme = new System.Windows.Forms.Button();
            this.btnDört = new System.Windows.Forms.Button();
            this.btnBeş = new System.Windows.Forms.Button();
            this.btnAltı = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnBir = new System.Windows.Forms.Button();
            this.btnİki = new System.Windows.Forms.Button();
            this.btnÜç = new System.Windows.Forms.Button();
            this.btnCıkarma = new System.Windows.Forms.Button();
            this.btnSıfır = new System.Windows.Forms.Button();
            this.btnNokta = new System.Windows.Forms.Button();
            this.btnEsittir = new System.Windows.Forms.Button();
            this.btnToplama = new System.Windows.Forms.Button();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.lblEkran = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnParantezAc
            // 
            this.btnParantezAc.Location = new System.Drawing.Point(31, 192);
            this.btnParantezAc.Name = "btnParantezAc";
            this.btnParantezAc.Size = new System.Drawing.Size(98, 33);
            this.btnParantezAc.TabIndex = 0;
            this.btnParantezAc.Text = "(";
            this.btnParantezAc.UseVisualStyleBackColor = true;
            this.btnParantezAc.Click += new System.EventHandler(this.btnParantezAc_Click);
            // 
            // btnParantezKapat
            // 
            this.btnParantezKapat.Location = new System.Drawing.Point(145, 192);
            this.btnParantezKapat.Name = "btnParantezKapat";
            this.btnParantezKapat.Size = new System.Drawing.Size(98, 33);
            this.btnParantezKapat.TabIndex = 1;
            this.btnParantezKapat.Text = ")";
            this.btnParantezKapat.UseVisualStyleBackColor = true;
            this.btnParantezKapat.Click += new System.EventHandler(this.btnParantezKapat_Click);
            // 
            // btnYuzde
            // 
            this.btnYuzde.Location = new System.Drawing.Point(260, 192);
            this.btnYuzde.Name = "btnYuzde";
            this.btnYuzde.Size = new System.Drawing.Size(98, 33);
            this.btnYuzde.TabIndex = 2;
            this.btnYuzde.Text = "%";
            this.btnYuzde.UseVisualStyleBackColor = true;
            this.btnYuzde.Click += new System.EventHandler(this.btnYuzde_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.Info;
            this.btnCE.Location = new System.Drawing.Point(374, 192);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(98, 33);
            this.btnCE.TabIndex = 3;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnYedi
            // 
            this.btnYedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedi.Location = new System.Drawing.Point(31, 255);
            this.btnYedi.Name = "btnYedi";
            this.btnYedi.Size = new System.Drawing.Size(98, 33);
            this.btnYedi.TabIndex = 4;
            this.btnYedi.Text = "7";
            this.btnYedi.UseVisualStyleBackColor = true;
            this.btnYedi.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btnSekiz
            // 
            this.btnSekiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekiz.Location = new System.Drawing.Point(145, 255);
            this.btnSekiz.Name = "btnSekiz";
            this.btnSekiz.Size = new System.Drawing.Size(98, 33);
            this.btnSekiz.TabIndex = 5;
            this.btnSekiz.Text = "8";
            this.btnSekiz.UseVisualStyleBackColor = true;
            this.btnSekiz.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btnDokuz
            // 
            this.btnDokuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDokuz.Location = new System.Drawing.Point(260, 255);
            this.btnDokuz.Name = "btnDokuz";
            this.btnDokuz.Size = new System.Drawing.Size(98, 33);
            this.btnDokuz.TabIndex = 6;
            this.btnDokuz.Text = "9";
            this.btnDokuz.UseVisualStyleBackColor = true;
            this.btnDokuz.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btnBölme
            // 
            this.btnBölme.BackColor = System.Drawing.Color.Red;
            this.btnBölme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBölme.Location = new System.Drawing.Point(374, 255);
            this.btnBölme.Name = "btnBölme";
            this.btnBölme.Size = new System.Drawing.Size(98, 33);
            this.btnBölme.TabIndex = 7;
            this.btnBölme.Text = "/";
            this.btnBölme.UseVisualStyleBackColor = false;
            this.btnBölme.Click += new System.EventHandler(this.btnBölme_Click);
            // 
            // btnDört
            // 
            this.btnDört.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDört.Location = new System.Drawing.Point(31, 310);
            this.btnDört.Name = "btnDört";
            this.btnDört.Size = new System.Drawing.Size(98, 33);
            this.btnDört.TabIndex = 8;
            this.btnDört.Text = "4";
            this.btnDört.UseVisualStyleBackColor = true;
            this.btnDört.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btnBeş
            // 
            this.btnBeş.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeş.Location = new System.Drawing.Point(145, 310);
            this.btnBeş.Name = "btnBeş";
            this.btnBeş.Size = new System.Drawing.Size(98, 33);
            this.btnBeş.TabIndex = 9;
            this.btnBeş.Text = "5";
            this.btnBeş.UseVisualStyleBackColor = true;
            this.btnBeş.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btnAltı
            // 
            this.btnAltı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAltı.Location = new System.Drawing.Point(260, 310);
            this.btnAltı.Name = "btnAltı";
            this.btnAltı.Size = new System.Drawing.Size(98, 33);
            this.btnAltı.TabIndex = 10;
            this.btnAltı.Text = "6";
            this.btnAltı.UseVisualStyleBackColor = true;
            this.btnAltı.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btnCarpma
            // 
            this.btnCarpma.BackColor = System.Drawing.Color.Red;
            this.btnCarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarpma.Location = new System.Drawing.Point(374, 310);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(98, 33);
            this.btnCarpma.TabIndex = 11;
            this.btnCarpma.Text = "X";
            this.btnCarpma.UseVisualStyleBackColor = false;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnBir
            // 
            this.btnBir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBir.Location = new System.Drawing.Point(31, 362);
            this.btnBir.Name = "btnBir";
            this.btnBir.Size = new System.Drawing.Size(98, 33);
            this.btnBir.TabIndex = 12;
            this.btnBir.Text = "1";
            this.btnBir.UseVisualStyleBackColor = true;
            this.btnBir.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btnİki
            // 
            this.btnİki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİki.Location = new System.Drawing.Point(145, 362);
            this.btnİki.Name = "btnİki";
            this.btnİki.Size = new System.Drawing.Size(98, 33);
            this.btnİki.TabIndex = 13;
            this.btnİki.Text = "2";
            this.btnİki.UseVisualStyleBackColor = true;
            this.btnİki.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btnÜç
            // 
            this.btnÜç.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÜç.Location = new System.Drawing.Point(260, 362);
            this.btnÜç.Name = "btnÜç";
            this.btnÜç.Size = new System.Drawing.Size(98, 33);
            this.btnÜç.TabIndex = 14;
            this.btnÜç.Text = "3";
            this.btnÜç.UseVisualStyleBackColor = true;
            this.btnÜç.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btnCıkarma
            // 
            this.btnCıkarma.BackColor = System.Drawing.Color.Red;
            this.btnCıkarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkarma.Location = new System.Drawing.Point(374, 362);
            this.btnCıkarma.Name = "btnCıkarma";
            this.btnCıkarma.Size = new System.Drawing.Size(98, 33);
            this.btnCıkarma.TabIndex = 15;
            this.btnCıkarma.Text = "-";
            this.btnCıkarma.UseVisualStyleBackColor = false;
            this.btnCıkarma.Click += new System.EventHandler(this.btnCıkarma_Click);
            // 
            // btnSıfır
            // 
            this.btnSıfır.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıfır.Location = new System.Drawing.Point(31, 414);
            this.btnSıfır.Name = "btnSıfır";
            this.btnSıfır.Size = new System.Drawing.Size(98, 33);
            this.btnSıfır.TabIndex = 16;
            this.btnSıfır.Text = "0";
            this.btnSıfır.UseVisualStyleBackColor = true;
            this.btnSıfır.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btnNokta
            // 
            this.btnNokta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNokta.Location = new System.Drawing.Point(145, 414);
            this.btnNokta.Name = "btnNokta";
            this.btnNokta.Size = new System.Drawing.Size(98, 33);
            this.btnNokta.TabIndex = 17;
            this.btnNokta.Text = ".";
            this.btnNokta.UseVisualStyleBackColor = true;
            this.btnNokta.Click += new System.EventHandler(this.btnNokta_Click);
            // 
            // btnEsittir
            // 
            this.btnEsittir.BackColor = System.Drawing.Color.Lime;
            this.btnEsittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEsittir.Location = new System.Drawing.Point(260, 414);
            this.btnEsittir.Name = "btnEsittir";
            this.btnEsittir.Size = new System.Drawing.Size(98, 33);
            this.btnEsittir.TabIndex = 18;
            this.btnEsittir.Text = "=";
            this.btnEsittir.UseVisualStyleBackColor = false;
            this.btnEsittir.Click += new System.EventHandler(this.btnEsittir_Click);
            // 
            // btnToplama
            // 
            this.btnToplama.BackColor = System.Drawing.Color.Red;
            this.btnToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplama.Location = new System.Drawing.Point(374, 414);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(98, 33);
            this.btnToplama.TabIndex = 19;
            this.btnToplama.Text = "+";
            this.btnToplama.UseVisualStyleBackColor = false;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // txtEkran
            // 
            this.txtEkran.BackColor = System.Drawing.Color.LightCyan;
            this.txtEkran.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkran.Location = new System.Drawing.Point(31, 28);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(441, 106);
            this.txtEkran.TabIndex = 20;
            // 
            // lblEkran
            // 
            this.lblEkran.AutoSize = true;
            this.lblEkran.Location = new System.Drawing.Point(428, 9);
            this.lblEkran.Name = "lblEkran";
            this.lblEkran.Size = new System.Drawing.Size(0, 13);
            this.lblEkran.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(495, 498);
            this.Controls.Add(this.lblEkran);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.btnToplama);
            this.Controls.Add(this.btnEsittir);
            this.Controls.Add(this.btnNokta);
            this.Controls.Add(this.btnSıfır);
            this.Controls.Add(this.btnCıkarma);
            this.Controls.Add(this.btnÜç);
            this.Controls.Add(this.btnİki);
            this.Controls.Add(this.btnBir);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnAltı);
            this.Controls.Add(this.btnBeş);
            this.Controls.Add(this.btnDört);
            this.Controls.Add(this.btnBölme);
            this.Controls.Add(this.btnDokuz);
            this.Controls.Add(this.btnSekiz);
            this.Controls.Add(this.btnYedi);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnYuzde);
            this.Controls.Add(this.btnParantezKapat);
            this.Controls.Add(this.btnParantezAc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelişmiş Hesap Makinası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParantezAc;
        private System.Windows.Forms.Button btnParantezKapat;
        private System.Windows.Forms.Button btnYuzde;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnYedi;
        private System.Windows.Forms.Button btnSekiz;
        private System.Windows.Forms.Button btnDokuz;
        private System.Windows.Forms.Button btnBölme;
        private System.Windows.Forms.Button btnDört;
        private System.Windows.Forms.Button btnBeş;
        private System.Windows.Forms.Button btnAltı;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnBir;
        private System.Windows.Forms.Button btnİki;
        private System.Windows.Forms.Button btnÜç;
        private System.Windows.Forms.Button btnCıkarma;
        private System.Windows.Forms.Button btnSıfır;
        private System.Windows.Forms.Button btnNokta;
        private System.Windows.Forms.Button btnEsittir;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.Label lblEkran;
    }
}

