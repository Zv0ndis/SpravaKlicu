namespace SprávaKlíčů
{
    partial class FormOdstranitZam
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
            this.ListboxZam = new System.Windows.Forms.ListBox();
            this.BtnZrusit = new System.Windows.Forms.Button();
            this.BtnOdstranitOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListboxZam
            // 
            this.ListboxZam.FormattingEnabled = true;
            this.ListboxZam.Location = new System.Drawing.Point(17, 18);
            this.ListboxZam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListboxZam.Name = "ListboxZam";
            this.ListboxZam.Size = new System.Drawing.Size(500, 316);
            this.ListboxZam.TabIndex = 19;
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(168, 376);
            this.BtnZrusit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(73, 24);
            this.BtnZrusit.TabIndex = 18;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // BtnOdstranitOK
            // 
            this.BtnOdstranitOK.Location = new System.Drawing.Point(17, 376);
            this.BtnOdstranitOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnOdstranitOK.Name = "BtnOdstranitOK";
            this.BtnOdstranitOK.Size = new System.Drawing.Size(136, 24);
            this.BtnOdstranitOK.TabIndex = 20;
            this.BtnOdstranitOK.Text = "Odstranit zaměstnance";
            this.BtnOdstranitOK.UseVisualStyleBackColor = true;
            this.BtnOdstranitOK.Click += new System.EventHandler(this.BtnOdstranitOK_Click);
            // 
            // FormOdstranitZam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 418);
            this.Controls.Add(this.BtnOdstranitOK);
            this.Controls.Add(this.ListboxZam);
            this.Controls.Add(this.BtnZrusit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormOdstranitZam";
            this.Text = "Odstranit zaměstnance";
            this.Load += new System.EventHandler(this.FormOdstranitZam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListboxZam;
        private System.Windows.Forms.Button BtnZrusit;
        private System.Windows.Forms.Button BtnOdstranitOK;
    }
}