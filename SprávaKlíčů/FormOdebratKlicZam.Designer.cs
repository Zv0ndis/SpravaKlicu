namespace SprávaKlíčů
{
    partial class FormOdebratKlicZam
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
            this.BtnZrusit = new System.Windows.Forms.Button();
            this.BtnDat = new System.Windows.Forms.Button();
            this.ListboxKlice = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListboxZam = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(334, 406);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(107, 33);
            this.BtnZrusit.TabIndex = 13;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            // 
            // BtnDat
            // 
            this.BtnDat.Location = new System.Drawing.Point(29, 406);
            this.BtnDat.Name = "BtnDat";
            this.BtnDat.Size = new System.Drawing.Size(281, 33);
            this.BtnDat.TabIndex = 12;
            this.BtnDat.Text = "Odebrat klíč zaměstnanci";
            this.BtnDat.UseVisualStyleBackColor = true;
            this.BtnDat.Click += new System.EventHandler(this.BtnDat_Click);
            // 
            // ListboxKlice
            // 
            this.ListboxKlice.FormattingEnabled = true;
            this.ListboxKlice.ItemHeight = 16;
            this.ListboxKlice.Location = new System.Drawing.Point(525, 56);
            this.ListboxKlice.Name = "ListboxKlice";
            this.ListboxKlice.Size = new System.Drawing.Size(463, 244);
            this.ListboxKlice.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vyberte klíč";
            // 
            // ListboxZam
            // 
            this.ListboxZam.FormattingEnabled = true;
            this.ListboxZam.ItemHeight = 16;
            this.ListboxZam.Location = new System.Drawing.Point(29, 56);
            this.ListboxZam.Name = "ListboxZam";
            this.ListboxZam.Size = new System.Drawing.Size(463, 244);
            this.ListboxZam.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vyberte zaměstnance: ";
            // 
            // FormOdebratKlicZam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 463);
            this.Controls.Add(this.BtnZrusit);
            this.Controls.Add(this.BtnDat);
            this.Controls.Add(this.ListboxKlice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListboxZam);
            this.Controls.Add(this.label1);
            this.Name = "FormOdebratKlicZam";
            this.Text = "Odebrat klíč zaměstnanci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnZrusit;
        private System.Windows.Forms.Button BtnDat;
        private System.Windows.Forms.ListBox ListboxKlice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListboxZam;
        private System.Windows.Forms.Label label1;
    }
}