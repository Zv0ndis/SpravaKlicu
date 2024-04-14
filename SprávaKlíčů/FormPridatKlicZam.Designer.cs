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
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vyberte zaměstnance: ";
            // 
            // ListboxZam
            // 
            this.ListboxZam.FormattingEnabled = true;
            this.ListboxZam.ItemHeight = 16;
            this.ListboxZam.Location = new System.Drawing.Point(31, 53);
            this.ListboxZam.Name = "ListboxZam";
            this.ListboxZam.Size = new System.Drawing.Size(463, 244);
            this.ListboxZam.TabIndex = 1;
            // 
            // ListboxKlice
            // 
            this.ListboxKlice.FormattingEnabled = true;
            this.ListboxKlice.ItemHeight = 16;
            this.ListboxKlice.Location = new System.Drawing.Point(527, 53);
            this.ListboxKlice.Name = "ListboxKlice";
            this.ListboxKlice.Size = new System.Drawing.Size(463, 244);
            this.ListboxKlice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vyberte klíč";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "datum reálné datum a ne přes tb hádám";
            // 
            // BtnDat
            // 
            this.BtnDat.Location = new System.Drawing.Point(31, 403);
            this.BtnDat.Name = "BtnDat";
            this.BtnDat.Size = new System.Drawing.Size(281, 33);
            this.BtnDat.TabIndex = 5;
            this.BtnDat.Text = "Přiřadit klíč zaměstnanci";
            this.BtnDat.UseVisualStyleBackColor = true;
            this.BtnDat.Click += new System.EventHandler(this.BtnDat_Click);
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(336, 403);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(107, 33);
            this.BtnZrusit.TabIndex = 6;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // FormPridatKlicZam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 473);
            this.Controls.Add(this.BtnZrusit);
            this.Controls.Add(this.BtnDat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListboxKlice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListboxZam);
            this.Controls.Add(this.label1);
            this.Name = "FormPridatKlicZam";
            this.Text = "Přidat klíč zaměstnanci";
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