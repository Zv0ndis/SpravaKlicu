namespace SprávaKlíčů
{
    partial class FormUpravitKlic
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
            this.ListboxKlice = new System.Windows.Forms.ListBox();
            this.BtnZrusit = new System.Windows.Forms.Button();
            this.BtnUpravitOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListboxKlice
            // 
            this.ListboxKlice.FormattingEnabled = true;
            this.ListboxKlice.Location = new System.Drawing.Point(16, 20);
            this.ListboxKlice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListboxKlice.Name = "ListboxKlice";
            this.ListboxKlice.Size = new System.Drawing.Size(500, 316);
            this.ListboxKlice.TabIndex = 19;
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(145, 378);
            this.BtnZrusit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(73, 24);
            this.BtnZrusit.TabIndex = 18;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // BtnUpravitOK
            // 
            this.BtnUpravitOK.Location = new System.Drawing.Point(16, 378);
            this.BtnUpravitOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnUpravitOK.Name = "BtnUpravitOK";
            this.BtnUpravitOK.Size = new System.Drawing.Size(112, 24);
            this.BtnUpravitOK.TabIndex = 17;
            this.BtnUpravitOK.Text = "Upravit klíč";
            this.BtnUpravitOK.UseVisualStyleBackColor = true;
            this.BtnUpravitOK.Click += new System.EventHandler(this.BtnUpravitOK_Click);
            // 
            // FormUpravitKlic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 426);
            this.Controls.Add(this.ListboxKlice);
            this.Controls.Add(this.BtnZrusit);
            this.Controls.Add(this.BtnUpravitOK);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUpravitKlic";
            this.Text = "Upravit informace o klíči";
            this.Load += new System.EventHandler(this.FormUpravitKlic_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListboxKlice;
        private System.Windows.Forms.Button BtnZrusit;
        private System.Windows.Forms.Button BtnUpravitOK;
    }
}