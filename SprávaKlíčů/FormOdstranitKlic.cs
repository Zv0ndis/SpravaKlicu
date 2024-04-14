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
    public partial class FormOdstranitKlic : Form
    {
        public FormOdstranitKlic()
        {
            InitializeComponent();
        }

        private void BtnOdstranitOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
