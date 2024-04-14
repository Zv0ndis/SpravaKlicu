namespace SprávaKlíčů
{
    partial class FormUpravitZam
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
            this.BtnUpravitOK = new System.Windows.Forms.Button();
            this.ListboxZam = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(146, 381);
            this.BtnZrusit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(73, 24);
            this.BtnZrusit.TabIndex = 15;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // BtnUpravitOK
            // 
            this.BtnUpravitOK.Location = new System.Drawing.Point(18, 381);
            this.BtnUpravitOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnUpravitOK.Name = "BtnUpravitOK";
            this.BtnUpravitOK.Size = new System.Drawing.Size(112, 24);
            this.BtnUpravitOK.TabIndex = 14;
            this.BtnUpravitOK.Text = "Upravit Zaměstnance";
            this.BtnUpravitOK.UseVisualStyleBackColor = true;
            this.BtnUpravitOK.Click += new System.EventHandler(this.BtnUpravitOK_Click);
            // 
            // ListboxZam
            // 
            this.ListboxZam.FormattingEnabled = true;
            this.ListboxZam.Location = new System.Drawing.Point(18, 23);
            this.ListboxZam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListboxZam.Name = "ListboxZam";
            this.ListboxZam.Size = new System.Drawing.Size(500, 316);
            this.ListboxZam.TabIndex = 16;
            // 
            // FormUpravitZam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 422);
            this.Controls.Add(this.ListboxZam);
            this.Controls.Add(this.BtnZrusit);
            this.Controls.Add(this.BtnUpravitOK);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUpravitZam";
            this.Text = "Upravit zaměstnance";
            this.Load += new System.EventHandler(this.FormUpravitZam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnZrusit;
        private System.Windows.Forms.Button BtnUpravitOK;
        private System.Windows.Forms.ListBox ListboxZam;
    }
}