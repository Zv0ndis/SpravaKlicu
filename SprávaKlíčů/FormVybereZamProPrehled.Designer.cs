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
            this.ListboxZam.ItemHeight = 16;
            this.ListboxZam.Location = new System.Drawing.Point(21, 22);
            this.ListboxZam.Name = "ListboxZam";
            this.ListboxZam.Size = new System.Drawing.Size(666, 388);
            this.ListboxZam.TabIndex = 19;
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(192, 463);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(97, 30);
            this.BtnZrusit.TabIndex = 18;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // BtnVyberZam
            // 
            this.BtnVyberZam.Location = new System.Drawing.Point(21, 463);
            this.BtnVyberZam.Name = "BtnVyberZam";
            this.BtnVyberZam.Size = new System.Drawing.Size(147, 30);
            this.BtnVyberZam.TabIndex = 20;
            this.BtnVyberZam.Text = "Vybrat zaměstnance";
            this.BtnVyberZam.UseVisualStyleBackColor = true;
            this.BtnVyberZam.Click += new System.EventHandler(this.BtnVyberZam_Click);
            // 
            // FormVybereZamProPrehled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.BtnVyberZam);
            this.Controls.Add(this.ListboxZam);
            this.Controls.Add(this.BtnZrusit);
            this.Name = "FormVybereZamProPrehled";
            this.Text = "FormVybereZamProPrehled";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListboxZam;
        private System.Windows.Forms.Button BtnZrusit;
        private System.Windows.Forms.Button BtnVyberZam;
    }
}