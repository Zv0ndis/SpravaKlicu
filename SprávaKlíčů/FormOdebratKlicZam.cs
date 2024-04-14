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
    public partial class FormOdebratKlicZam : Form
    {
        public FormOdebratKlicZam()
        {
            InitializeComponent();
        }





        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
