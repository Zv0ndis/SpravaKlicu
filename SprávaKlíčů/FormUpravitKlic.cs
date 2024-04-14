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
    public partial class FormUpravitKlic : Form
    {
        public FormUpravitKlic()
        {
            InitializeComponent();
        }

        private void BtnUpravitOK_Click(object sender, EventArgs e)
        {
            FormUpravovaciOknoKlic form = new FormUpravovaciOknoKlic(Data.klice[ListboxKlice.SelectedIndex]);
            form.Show();
            this.Close();
        }

        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpravitKlic_Load(object sender, EventArgs e)
        {
            foreach(Klic klic in Data.klice)
            {
                ListboxKlice.Items.Add($"{klic.Cislo} {klic.OznaceniDveri} {klic.NazevMistnosti}");
            }
        }
    }
}
