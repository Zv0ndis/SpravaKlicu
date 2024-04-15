using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprávaKlíčů
{
    public partial class FormVybereZamProPrehled : Form
    {
        public FormVybereZamProPrehled()
        {
            InitializeComponent();
        }

        private void BtnVyberZam_Click(object sender, EventArgs e)
        {
            // Získání vybraného zaměstnance z ListBoxu
            Zamestnanec selectedEmployee = ListboxZam.SelectedItem as Zamestnanec;

            // Zkontrolovat, zda byl vybrán nějaký zaměstnanec
            if (selectedEmployee != null)
            {
                // Zavolání metody pro zobrazení náhledu tisku
                PrinterManager printerManager = new PrinterManager();
                printerManager.PreviewKeysWithEmployee(selectedEmployee.ID);
            }
            else
            {
                MessageBox.Show("Prosím, vyberte zaměstnance.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVybereZamProPrehled_Load(object sender, EventArgs e)
        {
            // Naplnění ListBoxu seznamem zaměstnanců při načtení formuláře
            foreach (Zamestnanec zamestnanec in Data.zamestnanci)
            {
                // Přidání instance třídy Zamestnanec do ListBoxu
                ListboxZam.Items.Add(zamestnanec);
            }
        }

    }
}
