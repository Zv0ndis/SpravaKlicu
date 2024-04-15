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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(496, 25);
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
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
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
            this.button_prehled_vsech_zamestnancu.Click += new System.EventHandler(this.button_prehled_vsech_zamestnancu_Click);
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
            this.button_prehled_zamestnancu_s_klicem.Click += new System.EventHandler(this.button_prehled_zamestnancu_s_klicem_Click);
            // 
            // button_pocet_volnych_klicu
            // 
            this.button_pocet_volnych_klicu.Name = "button_pocet_volnych_klicu";
            this.button_pocet_volnych_klicu.Size = new System.Drawing.Size(233, 22);
            this.button_pocet_volnych_klicu.Text = "Počet volných klíčů";
            this.button_pocet_volnych_klicu.Click += new System.EventHandler(this.button_pocet_volnych_klicu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 318);
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
    }
}

