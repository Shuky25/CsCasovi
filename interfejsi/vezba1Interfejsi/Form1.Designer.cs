namespace vezba1Interfejsi
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrvi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDrugi = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPuta = new System.Windows.Forms.Button();
            this.btnPodeljeno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(75, 128);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prvi broj";
            // 
            // tbPrvi
            // 
            this.tbPrvi.Location = new System.Drawing.Point(137, 57);
            this.tbPrvi.Name = "tbPrvi";
            this.tbPrvi.Size = new System.Drawing.Size(100, 20);
            this.tbPrvi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drugi broj";
            // 
            // tbDrugi
            // 
            this.tbDrugi.Location = new System.Drawing.Point(137, 83);
            this.tbDrugi.Name = "tbDrugi";
            this.tbDrugi.Size = new System.Drawing.Size(100, 20);
            this.tbDrugi.TabIndex = 2;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(177, 128);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPuta
            // 
            this.btnPuta.Location = new System.Drawing.Point(75, 166);
            this.btnPuta.Name = "btnPuta";
            this.btnPuta.Size = new System.Drawing.Size(75, 23);
            this.btnPuta.TabIndex = 0;
            this.btnPuta.Text = "*";
            this.btnPuta.UseVisualStyleBackColor = true;
            this.btnPuta.Click += new System.EventHandler(this.btnPuta_Click);
            // 
            // btnPodeljeno
            // 
            this.btnPodeljeno.Location = new System.Drawing.Point(177, 166);
            this.btnPodeljeno.Name = "btnPodeljeno";
            this.btnPodeljeno.Size = new System.Drawing.Size(75, 23);
            this.btnPodeljeno.TabIndex = 0;
            this.btnPodeljeno.Text = "/";
            this.btnPodeljeno.UseVisualStyleBackColor = true;
            this.btnPodeljeno.Click += new System.EventHandler(this.btnPodeljeno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resenje";
            // 
            // tbRes
            // 
            this.tbRes.Location = new System.Drawing.Point(137, 215);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(100, 20);
            this.tbRes.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 309);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDrugi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrvi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPodeljeno);
            this.Controls.Add(this.btnPuta);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrvi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDrugi;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPuta;
        private System.Windows.Forms.Button btnPodeljeno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRes;
    }
}

