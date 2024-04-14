namespace SprávaKlíčů
{
    partial class FormPridatKlicZam
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListboxZam = new System.Windows.Forms.ListBox();
            this.ListboxKlice = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDat = new System.Windows.Forms.Button();
            this.BtnZrusit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vyberte zaměstnance: ";
            // 
            // ListboxZam
            // 
            this.ListboxZam.FormattingEnabled = true;
            this.ListboxZam.Location = new System.Drawing.Point(23, 43);
            this.ListboxZam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListboxZam.Name = "ListboxZam";
            this.ListboxZam.Size = new System.Drawing.Size(348, 199);
            this.ListboxZam.TabIndex = 1;
            // 
            // ListboxKlice
            // 
            this.ListboxKlice.FormattingEnabled = true;
            this.ListboxKlice.Location = new System.Drawing.Point(395, 43);
            this.ListboxKlice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListboxKlice.Name = "ListboxKlice";
            this.ListboxKlice.Size = new System.Drawing.Size(348, 199);
            this.ListboxKlice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vyberte klíč";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "datum reálné datum a ne přes tb hádám";
            // 
            // BtnDat
            // 
            this.BtnDat.Location = new System.Drawing.Point(23, 327);
            this.BtnDat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDat.Name = "BtnDat";
            this.BtnDat.Size = new System.Drawing.Size(211, 27);
            this.BtnDat.TabIndex = 5;
            this.BtnDat.Text = "Přiřadit klíč zaměstnanci";
            this.BtnDat.UseVisualStyleBackColor = true;
            this.BtnDat.Click += new System.EventHandler(this.BtnDat_Click);
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(252, 327);
            this.BtnZrusit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(80, 27);
            this.BtnZrusit.TabIndex = 6;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // FormPridatKlicZam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 384);
            this.Controls.Add(this.BtnZrusit);
            this.Controls.Add(this.BtnDat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListboxKlice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListboxZam);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPridatKlicZam";
            this.Text = "Přidat klíč zaměstnanci";
            this.Load += new System.EventHandler(this.FormPridatKlicZam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListboxZam;
        private System.Windows.Forms.ListBox ListboxKlice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDat;
        private System.Windows.Forms.Button BtnZrusit;
    }
}