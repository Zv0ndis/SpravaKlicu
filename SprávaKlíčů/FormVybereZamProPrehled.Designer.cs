namespace SprávaKlíčů
{
    partial class FormVybereZamProPrehled
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
            this.BtnVyberZam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListboxZam
            // 
            this.ListboxZam.FormattingEnabled = true;
            this.ListboxZam.Location = new System.Drawing.Point(16, 18);
            this.ListboxZam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListboxZam.Name = "ListboxZam";
            this.ListboxZam.Size = new System.Drawing.Size(500, 316);
            this.ListboxZam.TabIndex = 19;
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(144, 376);
            this.BtnZrusit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(73, 24);
            this.BtnZrusit.TabIndex = 18;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // BtnVyberZam
            // 
            this.BtnVyberZam.Location = new System.Drawing.Point(16, 376);
            this.BtnVyberZam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVyberZam.Name = "BtnVyberZam";
            this.BtnVyberZam.Size = new System.Drawing.Size(110, 24);
            this.BtnVyberZam.TabIndex = 20;
            this.BtnVyberZam.Text = "Vybrat zaměstnance";
            this.BtnVyberZam.UseVisualStyleBackColor = true;
            this.BtnVyberZam.Click += new System.EventHandler(this.BtnVyberZam_Click);
            // 
            // FormVybereZamProPrehled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 434);
            this.Controls.Add(this.BtnVyberZam);
            this.Controls.Add(this.ListboxZam);
            this.Controls.Add(this.BtnZrusit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVybereZamProPrehled";
            this.Text = "FormVybereZamProPrehled";
            this.Load += new System.EventHandler(this.FormVybereZamProPrehled_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListboxZam;
        private System.Windows.Forms.Button BtnZrusit;
        private System.Windows.Forms.Button BtnVyberZam;
    }
}