namespace SprávaKlíčů
{
    partial class FormOdstranitKlic
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
            this.BtnOdstranitOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListboxKlice
            // 
            this.ListboxKlice.FormattingEnabled = true;
            this.ListboxKlice.ItemHeight = 16;
            this.ListboxKlice.Location = new System.Drawing.Point(21, 22);
            this.ListboxKlice.Name = "ListboxKlice";
            this.ListboxKlice.Size = new System.Drawing.Size(666, 388);
            this.ListboxKlice.TabIndex = 19;
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
            // BtnOdstranitOK
            // 
            this.BtnOdstranitOK.Location = new System.Drawing.Point(21, 463);
            this.BtnOdstranitOK.Name = "BtnOdstranitOK";
            this.BtnOdstranitOK.Size = new System.Drawing.Size(149, 30);
            this.BtnOdstranitOK.TabIndex = 20;
            this.BtnOdstranitOK.Text = "Odstranit klíč";
            this.BtnOdstranitOK.UseVisualStyleBackColor = true;
            this.BtnOdstranitOK.Click += new System.EventHandler(this.BtnOdstranitOK_Click);
            // 
            // FormOdstranitKlic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.BtnOdstranitOK);
            this.Controls.Add(this.ListboxKlice);
            this.Controls.Add(this.BtnZrusit);
            this.Name = "FormOdstranitKlic";
            this.Text = "Odstranit klíč";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListboxKlice;
        private System.Windows.Forms.Button BtnZrusit;
        private System.Windows.Forms.Button BtnOdstranitOK;
    }
}