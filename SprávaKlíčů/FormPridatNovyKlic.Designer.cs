namespace SprávaKlíčů
{
    partial class FormPridatNovyKlic
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
            this.MTBCislo = new System.Windows.Forms.MaskedTextBox();
            this.BtnZrusit = new System.Windows.Forms.Button();
            this.BtnPridat = new System.Windows.Forms.Button();
            this.TBOznaceniDveri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNazevMistnosti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPocetKlicuNaPocatku = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MTBCislo
            // 
            this.MTBCislo.Location = new System.Drawing.Point(88, 24);
            this.MTBCislo.Mask = "0000";
            this.MTBCislo.Name = "MTBCislo";
            this.MTBCislo.Size = new System.Drawing.Size(48, 22);
            this.MTBCislo.TabIndex = 24;
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(184, 237);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(121, 30);
            this.BtnZrusit.TabIndex = 23;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // BtnPridat
            // 
            this.BtnPridat.Location = new System.Drawing.Point(28, 237);
            this.BtnPridat.Name = "BtnPridat";
            this.BtnPridat.Size = new System.Drawing.Size(150, 30);
            this.BtnPridat.TabIndex = 22;
            this.BtnPridat.Text = "Přidat klíč";
            this.BtnPridat.UseVisualStyleBackColor = true;
            this.BtnPridat.Click += new System.EventHandler(this.BtnPridat_Click);
            // 
            // TBOznaceniDveri
            // 
            this.TBOznaceniDveri.Location = new System.Drawing.Point(132, 107);
            this.TBOznaceniDveri.Name = "TBOznaceniDveri";
            this.TBOznaceniDveri.Size = new System.Drawing.Size(139, 22);
            this.TBOznaceniDveri.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Označení dveří";
            // 
            // TBNazevMistnosti
            // 
            this.TBNazevMistnosti.Location = new System.Drawing.Point(132, 64);
            this.TBNazevMistnosti.Name = "TBNazevMistnosti";
            this.TBNazevMistnosti.Size = new System.Drawing.Size(139, 22);
            this.TBNazevMistnosti.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Název místnosti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Číslo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Počet vyrobených kusů na počátku";
            // 
            // TBPocetKlicuNaPocatku
            // 
            this.TBPocetKlicuNaPocatku.Location = new System.Drawing.Point(246, 156);
            this.TBPocetKlicuNaPocatku.Name = "TBPocetKlicuNaPocatku";
            this.TBPocetKlicuNaPocatku.Size = new System.Drawing.Size(59, 22);
            this.TBPocetKlicuNaPocatku.TabIndex = 26;
            // 
            // FormPridatNovyKlic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 320);
            this.Controls.Add(this.TBPocetKlicuNaPocatku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MTBCislo);
            this.Controls.Add(this.BtnZrusit);
            this.Controls.Add(this.BtnPridat);
            this.Controls.Add(this.TBOznaceniDveri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNazevMistnosti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPridatNovyKlic";
            this.Text = "Přidat nový klíč";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MTBCislo;
        private System.Windows.Forms.Button BtnZrusit;
        private System.Windows.Forms.Button BtnPridat;
        private System.Windows.Forms.TextBox TBOznaceniDveri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNazevMistnosti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPocetKlicuNaPocatku;
    }
}