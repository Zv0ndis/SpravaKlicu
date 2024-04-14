namespace SprávaKlíčů
{
    partial class FormPridatNovehoZam
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
            this.TBJmeno = new System.Windows.Forms.TextBox();
            this.TBPrijmeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBZkratkaZamestnance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPridat = new System.Windows.Forms.Button();
            this.BtnZrusit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno";
            // 
            // TBJmeno
            // 
            this.TBJmeno.Location = new System.Drawing.Point(93, 48);
            this.TBJmeno.Name = "TBJmeno";
            this.TBJmeno.Size = new System.Drawing.Size(139, 22);
            this.TBJmeno.TabIndex = 1;
            // 
            // TBPrijmeni
            // 
            this.TBPrijmeni.Location = new System.Drawing.Point(93, 88);
            this.TBPrijmeni.Name = "TBPrijmeni";
            this.TBPrijmeni.Size = new System.Drawing.Size(139, 22);
            this.TBPrijmeni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Příjmení";
            // 
            // TBZkratkaZamestnance
            // 
            this.TBZkratkaZamestnance.Location = new System.Drawing.Point(171, 131);
            this.TBZkratkaZamestnance.Name = "TBZkratkaZamestnance";
            this.TBZkratkaZamestnance.Size = new System.Drawing.Size(139, 22);
            this.TBZkratkaZamestnance.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zkratka zaměstnance";
            // 
            // BtnPridat
            // 
            this.BtnPridat.Location = new System.Drawing.Point(33, 201);
            this.BtnPridat.Name = "BtnPridat";
            this.BtnPridat.Size = new System.Drawing.Size(150, 30);
            this.BtnPridat.TabIndex = 6;
            this.BtnPridat.Text = "Přidat zaměstnance";
            this.BtnPridat.UseVisualStyleBackColor = true;
            this.BtnPridat.Click += new System.EventHandler(this.BtnPridat_Click);
            // 
            // BtnZrusit
            // 
            this.BtnZrusit.Location = new System.Drawing.Point(189, 201);
            this.BtnZrusit.Name = "BtnZrusit";
            this.BtnZrusit.Size = new System.Drawing.Size(121, 30);
            this.BtnZrusit.TabIndex = 7;
            this.BtnZrusit.Text = "Zrušit";
            this.BtnZrusit.UseVisualStyleBackColor = true;
            this.BtnZrusit.Click += new System.EventHandler(this.BtnZrusit_Click);
            // 
            // FormPridatNovehoZam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 263);
            this.Controls.Add(this.BtnZrusit);
            this.Controls.Add(this.BtnPridat);
            this.Controls.Add(this.TBZkratkaZamestnance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBPrijmeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBJmeno);
            this.Controls.Add(this.label1);
            this.Name = "FormPridatNovehoZam";
            this.Text = "Přidat nového zaměstnance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBJmeno;
        private System.Windows.Forms.TextBox TBPrijmeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBZkratkaZamestnance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPridat;
        private System.Windows.Forms.Button BtnZrusit;
    }
}