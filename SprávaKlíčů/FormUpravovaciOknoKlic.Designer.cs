namespace SprávaKlíčů
{
    partial class FormUpravovaciOknoKlic
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
            this.TBPocetKlicuNaPocatku = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MTBCislo = new System.Windows.Forms.MaskedTextBox();
            this.BtnZrusit = new System.Windows.Forms.Button();
            this.TBOznaceniDveri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNazevMistnosti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUlozitZmeny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBPocetKlicuNaPocatku
            // 
            this.TBPocetKlicuNaPocatku.Location = new System.Drawing.Point(200, 123);
            this.TBPocetKlicuNaPocatku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPocetKlicuNaPocatku.Name = "TBPocetKlicuNaPocatku";
            this.TBPocetKlicuNaPocatku.Size = new System.Drawing.Size(45, 20);
            this.TBPocetKlicuNaPocatku.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Počet vyrobených kusů na počátku";
            // 
            // MTBCislo
            // 
            this.MTBCislo.Location = new System.Drawing.Point(68, 19);
            this.MTBCislo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MTBCislo.Mask = "0000";
            this.MTBCislo.Name = "MTBCislo";
            this.MTBCislo.Size = new System.Drawing.Size(37, 20);
            this.MTBCislo.TabIndex = 34;
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(140, 192);
            this.BtnZrusit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(91, 24);
            this.BtnZrusit.TabIndex = 33;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // TBOznaceniDveri
            // 
            this.TBOznaceniDveri.Location = new System.Drawing.Point(100, 86);
            this.TBOznaceniDveri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBOznaceniDveri.Name = "TBOznaceniDveri";
            this.TBOznaceniDveri.Size = new System.Drawing.Size(105, 20);
            this.TBOznaceniDveri.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Označení dveří";
            // 
            // TBNazevMistnosti
            // 
            this.TBNazevMistnosti.Location = new System.Drawing.Point(100, 51);
            this.TBNazevMistnosti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBNazevMistnosti.Name = "TBNazevMistnosti";
            this.TBNazevMistnosti.Size = new System.Drawing.Size(105, 20);
            this.TBNazevMistnosti.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Název místnosti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Číslo";
            // 
            // BtnUlozitZmeny
            // 
            this.BtnUlozitZmeny.Location = new System.Drawing.Point(22, 190);
            this.BtnUlozitZmeny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnUlozitZmeny.Name = "BtnUlozitZmeny";
            this.BtnUlozitZmeny.Size = new System.Drawing.Size(112, 26);
            this.BtnUlozitZmeny.TabIndex = 37;
            this.BtnUlozitZmeny.Text = "Uložit změny";
            this.BtnUlozitZmeny.UseVisualStyleBackColor = true;
            this.BtnUlozitZmeny.Click += new System.EventHandler(this.BtnUlozitZmeny_Click);
            // 
            // FormUpravovaciOknoKlic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 244);
            this.Controls.Add(this.BtnUlozitZmeny);
            this.Controls.Add(this.TBPocetKlicuNaPocatku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MTBCislo);
            this.Controls.Add(this.BtnZrusit);
            this.Controls.Add(this.TBOznaceniDveri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNazevMistnosti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUpravovaciOknoKlic";
            this.Text = "Upravování klíče";
            this.Load += new System.EventHandler(this.FormUpravovaciOknoKlic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBPocetKlicuNaPocatku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MTBCislo;
        private System.Windows.Forms.Button BtnZrusit;
        private System.Windows.Forms.TextBox TBOznaceniDveri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNazevMistnosti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUlozitZmeny;
    }
}