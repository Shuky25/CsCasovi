namespace voziloKlasa
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
            this.lbVozilo = new System.Windows.Forms.ListBox();
            this.lbAuto = new System.Windows.Forms.ListBox();
            this.lbKamion = new System.Windows.Forms.ListBox();
            this.lbAutobus = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbVozilo
            // 
            this.lbVozilo.FormattingEnabled = true;
            this.lbVozilo.Location = new System.Drawing.Point(15, 46);
            this.lbVozilo.Name = "lbVozilo";
            this.lbVozilo.Size = new System.Drawing.Size(730, 290);
            this.lbVozilo.TabIndex = 0;
            // 
            // lbAuto
            // 
            this.lbAuto.FormattingEnabled = true;
            this.lbAuto.Location = new System.Drawing.Point(12, 356);
            this.lbAuto.Name = "lbAuto";
            this.lbAuto.Size = new System.Drawing.Size(733, 82);
            this.lbAuto.TabIndex = 0;
            // 
            // lbKamion
            // 
            this.lbKamion.FormattingEnabled = true;
            this.lbKamion.Location = new System.Drawing.Point(12, 457);
            this.lbKamion.Name = "lbKamion";
            this.lbKamion.Size = new System.Drawing.Size(733, 95);
            this.lbKamion.TabIndex = 0;
            // 
            // lbAutobus
            // 
            this.lbAutobus.FormattingEnabled = true;
            this.lbAutobus.Location = new System.Drawing.Point(12, 571);
            this.lbAutobus.Name = "lbAutobus";
            this.lbAutobus.Size = new System.Drawing.Size(733, 95);
            this.lbAutobus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vozilo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Automobil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kamion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Autobus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAutobus);
            this.Controls.Add(this.lbKamion);
            this.Controls.Add(this.lbAuto);
            this.Controls.Add(this.lbVozilo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVozilo;
        private System.Windows.Forms.ListBox lbAuto;
        private System.Windows.Forms.ListBox lbKamion;
        private System.Windows.Forms.ListBox lbAutobus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

