namespace SprávaKlíčů
{
    partial class FormUpravovaciOknoZam
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
            this.TBZkratkaZamestnance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBPrijmeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBJmeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUlozitZmeny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(143, 150);
            this.BtnZrusit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(91, 24);
            this.BtnZrusit.TabIndex = 15;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // TBZkratkaZamestnance
            // 
            this.TBZkratkaZamestnance.Location = new System.Drawing.Point(130, 93);
            this.TBZkratkaZamestnance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBZkratkaZamestnance.Name = "TBZkratkaZamestnance";
            this.TBZkratkaZamestnance.Size = new System.Drawing.Size(105, 20);
            this.TBZkratkaZamestnance.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Zkratka zaměstnance";
            // 
            // TBPrijmeni
            // 
            this.TBPrijmeni.Location = new System.Drawing.Point(71, 58);
            this.TBPrijmeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPrijmeni.Name = "TBPrijmeni";
            this.TBPrijmeni.Size = new System.Drawing.Size(105, 20);
            this.TBPrijmeni.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Příjmení";
            // 
            // TBJmeno
            // 
            this.TBJmeno.Location = new System.Drawing.Point(71, 26);
            this.TBJmeno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBJmeno.Name = "TBJmeno";
            this.TBJmeno.Size = new System.Drawing.Size(105, 20);
            this.TBJmeno.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jméno";
            // 
            // BtnUlozitZmeny
            // 
            this.BtnUlozitZmeny.Location = new System.Drawing.Point(26, 150);
            this.BtnUlozitZmeny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnUlozitZmeny.Name = "BtnUlozitZmeny";
            this.BtnUlozitZmeny.Size = new System.Drawing.Size(112, 24);
            this.BtnUlozitZmeny.TabIndex = 16;
            this.BtnUlozitZmeny.Text = "Uložit změny";
            this.BtnUlozitZmeny.UseVisualStyleBackColor = true;
            this.BtnUlozitZmeny.Click += new System.EventHandler(this.BtnUlozitZmeny_Click);
            // 
            // FormUpravovaciOknoZam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 210);
            this.Controls.Add(this.BtnUlozitZmeny);
            this.Controls.Add(this.BtnZrusit);
            this.Controls.Add(this.TBZkratkaZamestnance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBPrijmeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBJmeno);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUpravovaciOknoZam";
            this.Text = "Upravování zaměstnance";
            this.Load += new System.EventHandler(this.FormUpravovaciOknoZam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnZrusit;
        private System.Windows.Forms.TextBox TBZkratkaZamestnance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBPrijmeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBJmeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUlozitZmeny;
    }
}