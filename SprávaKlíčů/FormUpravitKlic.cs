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
            FormUpravovaciOknoKlic form = new FormUpravovaciOknoKlic();
            form.Show();
            this.Close();
        }

        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
