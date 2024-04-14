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
    public partial class FormUpravitZam : Form
    {
        public FormUpravitZam()
        {
            InitializeComponent();
        }

        private void BtnUpravitOK_Click(object sender, EventArgs e)
        {
            FormUpravovaciOknoZam form = new FormUpravovaciOknoZam(Data.zamestnanci[ListboxZam.SelectedIndex]);
            form.Show();
            this.Close();
        }

        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpravitZam_Load(object sender, EventArgs e)
        {
            foreach(Zamestnanec zamestnanec in Data.zamestnanci)
            {
                ListboxZam.Items.Add($"{zamestnanec.Jmeno} {zamestnanec.Prijmeni}");
            }
        }
    }
}
