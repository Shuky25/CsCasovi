namespace zadatakListe
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbElement = new System.Windows.Forms.TextBox();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.btnObrni = new System.Windows.Forms.Button();
            this.btnObIzbor = new System.Windows.Forms.Button();
            this.btnUbaci = new System.Windows.Forms.Button();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.btnIspisNiz = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnNovaLista = new System.Windows.Forms.Button();
            this.lbNiz = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labNalazi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(20, 116);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Element liste";
            // 
            // tbElement
            // 
            this.tbElement.Location = new System.Drawing.Point(21, 58);
            this.tbElement.Name = "tbElement";
            this.tbElement.Size = new System.Drawing.Size(100, 20);
            this.tbElement.TabIndex = 0;
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(29, 193);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(125, 173);
            this.lbLista.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Index";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Broj";
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(291, 65);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(100, 20);
            this.tbBroj.TabIndex = 11;
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(291, 39);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(100, 20);
            this.tbIndex.TabIndex = 10;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(101, 116);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(75, 23);
            this.btnIspisi.TabIndex = 2;
            this.btnIspisi.Text = "Ispisi";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // btnObrni
            // 
            this.btnObrni.Location = new System.Drawing.Point(182, 116);
            this.btnObrni.Name = "btnObrni";
            this.btnObrni.Size = new System.Drawing.Size(75, 23);
            this.btnObrni.TabIndex = 3;
            this.btnObrni.Text = "Obrni";
            this.btnObrni.UseVisualStyleBackColor = true;
            this.btnObrni.Click += new System.EventHandler(this.btnObrni_Click);
            // 
            // btnObIzbor
            // 
            this.btnObIzbor.Location = new System.Drawing.Point(263, 116);
            this.btnObIzbor.Name = "btnObIzbor";
            this.btnObIzbor.Size = new System.Drawing.Size(75, 23);
            this.btnObIzbor.TabIndex = 4;
            this.btnObIzbor.Text = "Obrni izbor";
            this.btnObIzbor.UseVisualStyleBackColor = true;
            this.btnObIzbor.Click += new System.EventHandler(this.btnObIzbor_Click);
            // 
            // btnUbaci
            // 
            this.btnUbaci.Location = new System.Drawing.Point(344, 116);
            this.btnUbaci.Name = "btnUbaci";
            this.btnUbaci.Size = new System.Drawing.Size(75, 23);
            this.btnUbaci.TabIndex = 5;
            this.btnUbaci.Text = "Ubaci";
            this.btnUbaci.UseVisualStyleBackColor = true;
            this.btnUbaci.Click += new System.EventHandler(this.btnUbaci_Click);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(20, 151);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSortiraj.TabIndex = 6;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // btnIspisNiz
            // 
            this.btnIspisNiz.Location = new System.Drawing.Point(101, 151);
            this.btnIspisNiz.Name = "btnIspisNiz";
            this.btnIspisNiz.Size = new System.Drawing.Size(75, 23);
            this.btnIspisNiz.TabIndex = 7;
            this.btnIspisNiz.Text = "Ispisi niz";
            this.btnIspisNiz.UseVisualStyleBackColor = true;
            this.btnIspisNiz.Click += new System.EventHandler(this.btnIspisNiz_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(182, 151);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnBrisi.TabIndex = 8;
            this.btnBrisi.Text = "Brisi listu";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnNovaLista
            // 
            this.btnNovaLista.Location = new System.Drawing.Point(263, 151);
            this.btnNovaLista.Name = "btnNovaLista";
            this.btnNovaLista.Size = new System.Drawing.Size(75, 23);
            this.btnNovaLista.TabIndex = 9;
            this.btnNovaLista.Text = "Nova lista";
            this.btnNovaLista.UseVisualStyleBackColor = true;
            this.btnNovaLista.Click += new System.EventHandler(this.btnNovaLista_Click);
            // 
            // lbNiz
            // 
            this.lbNiz.FormattingEnabled = true;
            this.lbNiz.Location = new System.Drawing.Point(287, 193);
            this.lbNiz.Name = "lbNiz";
            this.lbNiz.Size = new System.Drawing.Size(125, 173);
            this.lbNiz.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Da li se nalazi";
            // 
            // labNalazi
            // 
            this.labNalazi.AutoSize = true;
            this.labNalazi.Location = new System.Drawing.Point(170, 276);
            this.labNalazi.Name = "labNalazi";
            this.labNalazi.Size = new System.Drawing.Size(39, 13);
            this.labNalazi.TabIndex = 1;
            this.labNalazi.Text = "dwada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 382);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbNiz);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.tbElement);
            this.Controls.Add(this.labNalazi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUbaci);
            this.Controls.Add(this.btnNovaLista);
            this.Controls.Add(this.btnObIzbor);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnObrni);
            this.Controls.Add(this.btnIspisNiz);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbElement;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Button btnObrni;
        private System.Windows.Forms.Button btnObIzbor;
        private System.Windows.Forms.Button btnUbaci;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button btnIspisNiz;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnNovaLista;
        private System.Windows.Forms.ListBox lbNiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labNalazi;
    }
}

