namespace for4_1691
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
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(86, 84);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(100, 20);
            this.txtBaslangic.TabIndex = 0;
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(102, 224);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(75, 23);
            this.btnYaz.TabIndex = 1;
            this.btnYaz.Text = "button1";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(86, 153);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(100, 20);
            this.txtBitis.TabIndex = 2;
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(228, 84);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(120, 173);
            this.lbSayilar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSayilar);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.txtBaslangic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.ListBox lbSayilar;
    }
}

