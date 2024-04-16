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
            Zamestnanec selectedEmployee = ListboxZam.SelectedItem as Zamestnanec;

            if (selectedEmployee != null)
            {
                PrinterManager printerManager = new PrinterManager();
                printerManager.PreviewKlíčeZaměstnance(selectedEmployee.ID);
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
            foreach (Zamestnanec zamestnanec in Data.zamestnanci)
            {
                ListboxZam.Items.Add(zamestnanec);
            }
        }

    }
}
