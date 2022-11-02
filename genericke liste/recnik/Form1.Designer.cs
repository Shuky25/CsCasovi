namespace recnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbKljuc = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lbPar = new System.Windows.Forms.ListBox();
            this.cbKljuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVrednost = new System.Windows.Forms.TextBox();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.btnIspisiPar = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnObrisiPar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbVrednost = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kljuc";
            // 
            // tbKljuc
            // 
            this.tbKljuc.Location = new System.Drawing.Point(94, 32);
            this.tbKljuc.Name = "tbKljuc";
            this.tbKljuc.Size = new System.Drawing.Size(85, 20);
            this.tbKljuc.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(13, 102);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lbPar
            // 
            this.lbPar.FormattingEnabled = true;
            this.lbPar.Location = new System.Drawing.Point(42, 172);
            this.lbPar.Name = "lbPar";
            this.lbPar.Size = new System.Drawing.Size(120, 95);
            this.lbPar.TabIndex = 3;
            // 
            // cbKljuc
            // 
            this.cbKljuc.FormattingEnabled = true;
            this.cbKljuc.Location = new System.Drawing.Point(195, 196);
            this.cbKljuc.Name = "cbKljuc";
            this.cbKljuc.Size = new System.Drawing.Size(64, 21);
            this.cbKljuc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vrednost";
            // 
            // tbVrednost
            // 
            this.tbVrednost.Location = new System.Drawing.Point(94, 58);
            this.tbVrednost.Name = "tbVrednost";
            this.tbVrednost.Size = new System.Drawing.Size(85, 20);
            this.tbVrednost.TabIndex = 1;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(94, 102);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(75, 23);
            this.btnIspisi.TabIndex = 3;
            this.btnIspisi.Text = "Ispisi";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // btnIspisiPar
            // 
            this.btnIspisiPar.Location = new System.Drawing.Point(175, 102);
            this.btnIspisiPar.Name = "btnIspisiPar";
            this.btnIspisiPar.Size = new System.Drawing.Size(75, 23);
            this.btnIspisiPar.TabIndex = 4;
            this.btnIspisiPar.Text = "Ispisi par";
            this.btnIspisiPar.UseVisualStyleBackColor = true;
            this.btnIspisiPar.Click += new System.EventHandler(this.btnIspisiPar_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.Location = new System.Drawing.Point(256, 102);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromeni.TabIndex = 5;
            this.btnPromeni.Text = "Promeni";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnObrisiPar
            // 
            this.btnObrisiPar.Location = new System.Drawing.Point(337, 102);
            this.btnObrisiPar.Name = "btnObrisiPar";
            this.btnObrisiPar.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiPar.TabIndex = 6;
            this.btnObrisiPar.Text = "Obrisi par";
            this.btnObrisiPar.UseVisualStyleBackColor = true;
            this.btnObrisiPar.Click += new System.EventHandler(this.btnObrisiPar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Parovi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kljuc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vrenost";
            // 
            // cbVrednost
            // 
            this.cbVrednost.FormattingEnabled = true;
            this.cbVrednost.Location = new System.Drawing.Point(309, 196);
            this.cbVrednost.Name = "cbVrednost";
            this.cbVrednost.Size = new System.Drawing.Size(64, 21);
            this.cbVrednost.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 298);
            this.Controls.Add(this.cbVrednost);
            this.Controls.Add(this.cbKljuc);
            this.Controls.Add(this.lbPar);
            this.Controls.Add(this.btnObrisiPar);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.btnIspisiPar);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbVrednost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbKljuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKljuc;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lbPar;
        private System.Windows.Forms.ComboBox cbKljuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVrednost;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Button btnIspisiPar;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnObrisiPar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbVrednost;
    }
}

