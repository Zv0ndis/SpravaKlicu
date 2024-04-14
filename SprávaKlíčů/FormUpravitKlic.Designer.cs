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
            this.ListboxKlice.ItemHeight = 16;
            this.ListboxKlice.Location = new System.Drawing.Point(22, 24);
            this.ListboxKlice.Name = "ListboxKlice";
            this.ListboxKlice.Size = new System.Drawing.Size(666, 388);
            this.ListboxKlice.TabIndex = 19;
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(193, 465);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(97, 30);
            this.BtnZrusit.TabIndex = 18;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // BtnUpravitOK
            // 
            this.BtnUpravitOK.Location = new System.Drawing.Point(22, 465);
            this.BtnUpravitOK.Name = "BtnUpravitOK";
            this.BtnUpravitOK.Size = new System.Drawing.Size(150, 30);
            this.BtnUpravitOK.TabIndex = 17;
            this.BtnUpravitOK.Text = "Upravit klíč";
            this.BtnUpravitOK.UseVisualStyleBackColor = true;
            this.BtnUpravitOK.Click += new System.EventHandler(this.BtnUpravitOK_Click);
            // 
            // FormUpravitKlic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.ListboxKlice);
            this.Controls.Add(this.BtnZrusit);
            this.Controls.Add(this.BtnUpravitOK);
            this.Name = "FormUpravitKlic";
            this.Text = "Upravit informace o klíči";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListboxKlice;
        private System.Windows.Forms.Button BtnZrusit;
        private System.Windows.Forms.Button BtnUpravitOK;
    }
}