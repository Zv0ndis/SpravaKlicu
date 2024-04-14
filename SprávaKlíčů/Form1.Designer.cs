namespace SprávaKlíčů
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funkceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_zamestnanec = new System.Windows.Forms.ToolStripMenuItem();
            this.button_pridat_noveho_zamestnance = new System.Windows.Forms.ToolStripMenuItem();
            this.button_upravit_zamestnance = new System.Windows.Forms.ToolStripMenuItem();
            this.button_odstranit_zamestnance = new System.Windows.Forms.ToolStripMenuItem();
            this.button_klic = new System.Windows.Forms.ToolStripMenuItem();
            this.button_pridat_klic = new System.Windows.Forms.ToolStripMenuItem();
            this.button_upravit_klic = new System.Windows.Forms.ToolStripMenuItem();
            this.button_odstranit_klic = new System.Windows.Forms.ToolStripMenuItem();
            this.button_priradit_klic_zamestnanci = new System.Windows.Forms.ToolStripMenuItem();
            this.button_odebrat_klic_zamestnanci = new System.Windows.Forms.ToolStripMenuItem();
            this.button_prehled = new System.Windows.Forms.ToolStripMenuItem();
            this.button_prehled_vsech_zamestnancu = new System.Windows.Forms.ToolStripMenuItem();
            this.button_prehled_klicu_zamestnance = new System.Windows.Forms.ToolStripMenuItem();
            this.button_prehled_zamestnancu_s_klicem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_pocet_volnych_klicu = new System.Windows.Forms.ToolStripMenuItem();
            this.TBPrehled = new System.Windows.Forms.TextBox();
            this.BtnTisk = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.BtnNahled = new System.Windows.Forms.Button();
            this.BtnNastaveni = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(761, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funkceToolStripMenuItem,
            this.button_prehled});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funkceToolStripMenuItem
            // 
            this.funkceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_zamestnanec,
            this.button_klic,
            this.button_priradit_klic_zamestnanci,
            this.button_odebrat_klic_zamestnanci});
            this.funkceToolStripMenuItem.Name = "funkceToolStripMenuItem";
            this.funkceToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.funkceToolStripMenuItem.Text = "Funkce";
            // 
            // button_zamestnanec
            // 
            this.button_zamestnanec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_pridat_noveho_zamestnance,
            this.button_upravit_zamestnance,
            this.button_odstranit_zamestnance});
            this.button_zamestnanec.Name = "button_zamestnanec";
            this.button_zamestnanec.Size = new System.Drawing.Size(207, 22);
            this.button_zamestnanec.Text = "Zaměstnanec";
            // 
            // button_pridat_noveho_zamestnance
            // 
            this.button_pridat_noveho_zamestnance.Name = "button_pridat_noveho_zamestnance";
            this.button_pridat_noveho_zamestnance.Size = new System.Drawing.Size(220, 22);
            this.button_pridat_noveho_zamestnance.Text = "Přidat nového zaměstnance";
            this.button_pridat_noveho_zamestnance.Click += new System.EventHandler(this.button_pridat_noveho_zamestnance_Click);
            // 
            // button_upravit_zamestnance
            // 
            this.button_upravit_zamestnance.Name = "button_upravit_zamestnance";
            this.button_upravit_zamestnance.Size = new System.Drawing.Size(220, 22);
            this.button_upravit_zamestnance.Text = "Upravit zaměstnance";
            this.button_upravit_zamestnance.Click += new System.EventHandler(this.button_upravit_zamestnance_Click);
            // 
            // button_odstranit_zamestnance
            // 
            this.button_odstranit_zamestnance.Name = "button_odstranit_zamestnance";
            this.button_odstranit_zamestnance.Size = new System.Drawing.Size(220, 22);
            this.button_odstranit_zamestnance.Text = "Odstranit zaměstnance";
            this.button_odstranit_zamestnance.Click += new System.EventHandler(this.button_odstranit_zamestnance_Click);
            // 
            // button_klic
            // 
            this.button_klic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_pridat_klic,
            this.button_upravit_klic,
            this.button_odstranit_klic});
            this.button_klic.Name = "button_klic";
            this.button_klic.Size = new System.Drawing.Size(207, 22);
            this.button_klic.Text = "Klíč";
            // 
            // button_pridat_klic
            // 
            this.button_pridat_klic.Name = "button_pridat_klic";
            this.button_pridat_klic.Size = new System.Drawing.Size(203, 22);
            this.button_pridat_klic.Text = "Přidat nový klíč";
            this.button_pridat_klic.Click += new System.EventHandler(this.button_pridat_klic_Click);
            // 
            // button_upravit_klic
            // 
            this.button_upravit_klic.Name = "button_upravit_klic";
            this.button_upravit_klic.Size = new System.Drawing.Size(203, 22);
            this.button_upravit_klic.Text = "Upravit informace o klíči";
            this.button_upravit_klic.Click += new System.EventHandler(this.button_upravit_klic_Click);
            // 
            // button_odstranit_klic
            // 
            this.button_odstranit_klic.Name = "button_odstranit_klic";
            this.button_odstranit_klic.Size = new System.Drawing.Size(203, 22);
            this.button_odstranit_klic.Text = "Odstranit klíč";
            this.button_odstranit_klic.Click += new System.EventHandler(this.button_odstranit_klic_Click);
            // 
            // button_priradit_klic_zamestnanci
            // 
            this.button_priradit_klic_zamestnanci.Name = "button_priradit_klic_zamestnanci";
            this.button_priradit_klic_zamestnanci.Size = new System.Drawing.Size(207, 22);
            this.button_priradit_klic_zamestnanci.Text = "Přiřadit klíč zaměstnanci";
            this.button_priradit_klic_zamestnanci.Click += new System.EventHandler(this.button_priradit_klic_zamestnanci_Click);
            // 
            // button_odebrat_klic_zamestnanci
            // 
            this.button_odebrat_klic_zamestnanci.Name = "button_odebrat_klic_zamestnanci";
            this.button_odebrat_klic_zamestnanci.Size = new System.Drawing.Size(207, 22);
            this.button_odebrat_klic_zamestnanci.Text = "Odebrat klíč zaměstnanci";
            this.button_odebrat_klic_zamestnanci.Click += new System.EventHandler(this.button_odebrat_klic_zamestnanci_Click);
            // 
            // button_prehled
            // 
            this.button_prehled.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_prehled_vsech_zamestnancu,
            this.button_prehled_klicu_zamestnance,
            this.button_prehled_zamestnancu_s_klicem,
            this.button_pocet_volnych_klicu});
            this.button_prehled.Name = "button_prehled";
            this.button_prehled.Size = new System.Drawing.Size(65, 20);
            this.button_prehled.Text = "Přehledy";
            // 
            // button_prehled_vsech_zamestnancu
            // 
            this.button_prehled_vsech_zamestnancu.Name = "button_prehled_vsech_zamestnancu";
            this.button_prehled_vsech_zamestnancu.Size = new System.Drawing.Size(233, 22);
            this.button_prehled_vsech_zamestnancu.Text = "Přehled všech zaměstnanců";
            // 
            // button_prehled_klicu_zamestnance
            // 
            this.button_prehled_klicu_zamestnance.Name = "button_prehled_klicu_zamestnance";
            this.button_prehled_klicu_zamestnance.Size = new System.Drawing.Size(233, 22);
            this.button_prehled_klicu_zamestnance.Text = "Přehled klíčů zaměstnance";
            this.button_prehled_klicu_zamestnance.Click += new System.EventHandler(this.button_prehled_klicu_zamestnance_Click);
            // 
            // button_prehled_zamestnancu_s_klicem
            // 
            this.button_prehled_zamestnancu_s_klicem.Name = "button_prehled_zamestnancu_s_klicem";
            this.button_prehled_zamestnancu_s_klicem.Size = new System.Drawing.Size(233, 22);
            this.button_prehled_zamestnancu_s_klicem.Text = "Přehled zaměstnanců s klíčem";
            // 
            // button_pocet_volnych_klicu
            // 
            this.button_pocet_volnych_klicu.Name = "button_pocet_volnych_klicu";
            this.button_pocet_volnych_klicu.Size = new System.Drawing.Size(233, 22);
            this.button_pocet_volnych_klicu.Text = "Počet volných klíčů";
            // 
            // TBPrehled
            // 
            this.TBPrehled.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TBPrehled.Location = new System.Drawing.Point(16, 46);
            this.TBPrehled.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPrehled.Multiline = true;
            this.TBPrehled.Name = "TBPrehled";
            this.TBPrehled.ReadOnly = true;
            this.TBPrehled.Size = new System.Drawing.Size(254, 388);
            this.TBPrehled.TabIndex = 2;
            // 
            // BtnTisk
            // 
            this.BtnTisk.Location = new System.Drawing.Point(481, 412);
            this.BtnTisk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnTisk.Name = "BtnTisk";
            this.BtnTisk.Size = new System.Drawing.Size(82, 22);
            this.BtnTisk.TabIndex = 4;
            this.BtnTisk.Text = "Tisk";
            this.BtnTisk.UseVisualStyleBackColor = true;
            this.BtnTisk.Click += new System.EventHandler(this.BtnTisk_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(258, 265);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(100, 100);
            this.printPreviewControl1.TabIndex = 5;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // BtnNahled
            // 
            this.BtnNahled.Location = new System.Drawing.Point(320, 412);
            this.BtnNahled.Name = "BtnNahled";
            this.BtnNahled.Size = new System.Drawing.Size(75, 23);
            this.BtnNahled.TabIndex = 6;
            this.BtnNahled.Text = "Nahled";
            this.BtnNahled.UseVisualStyleBackColor = true;
            this.BtnNahled.Click += new System.EventHandler(this.BtnNahled_Click);
            // 
            // BtnNastaveni
            // 
            this.BtnNastaveni.Location = new System.Drawing.Point(401, 411);
            this.BtnNastaveni.Name = "BtnNastaveni";
            this.BtnNastaveni.Size = new System.Drawing.Size(75, 23);
            this.BtnNastaveni.TabIndex = 7;
            this.BtnNastaveni.Text = "Nastaveni";
            this.BtnNastaveni.UseVisualStyleBackColor = true;
            this.BtnNastaveni.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.BtnNastaveni);
            this.Controls.Add(this.BtnNahled);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.BtnTisk);
            this.Controls.Add(this.TBPrehled);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Správa klíčů";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funkceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem button_zamestnanec;
        private System.Windows.Forms.ToolStripMenuItem button_pridat_noveho_zamestnance;
        private System.Windows.Forms.ToolStripMenuItem button_upravit_zamestnance;
        private System.Windows.Forms.ToolStripMenuItem button_odstranit_zamestnance;
        private System.Windows.Forms.ToolStripMenuItem button_klic;
        private System.Windows.Forms.ToolStripMenuItem button_pridat_klic;
        private System.Windows.Forms.ToolStripMenuItem button_upravit_klic;
        private System.Windows.Forms.ToolStripMenuItem button_odstranit_klic;
        private System.Windows.Forms.ToolStripMenuItem button_priradit_klic_zamestnanci;
        private System.Windows.Forms.ToolStripMenuItem button_odebrat_klic_zamestnanci;
        private System.Windows.Forms.ToolStripMenuItem button_prehled;
        private System.Windows.Forms.ToolStripMenuItem button_prehled_vsech_zamestnancu;
        private System.Windows.Forms.ToolStripMenuItem button_prehled_klicu_zamestnance;
        private System.Windows.Forms.ToolStripMenuItem button_prehled_zamestnancu_s_klicem;
        private System.Windows.Forms.ToolStripMenuItem button_pocet_volnych_klicu;
        private System.Windows.Forms.TextBox TBPrehled;
        private System.Windows.Forms.Button BtnTisk;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button BtnNahled;
        private System.Windows.Forms.Button BtnNastaveni;
    }
}

