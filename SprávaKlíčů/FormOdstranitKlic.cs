using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            if (ListboxKlice.SelectedIndex > -1)
            {
                using (SqlConnection connection = new SqlConnection(Data.connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE ID = @ID", connection, transaction);
                        cmd.Parameters.AddWithValue("@ID", Data.klice[ListboxKlice.SelectedIndex].ID);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        Data.klice.Remove(Data.klice[ListboxKlice.SelectedIndex]);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Chyba při odstraňování klíče: " + Environment.NewLine + ex.Message);
                    }
                }
            }
            this.Close();
        }

        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOdstranitKlic_Load(object sender, EventArgs e)
        {
            foreach (Klic klic in Data.klice)
            {
                ListboxKlice.Items.Add($"{klic.Cislo} {klic.NazevMistnosti} {klic.OznaceniDveri}");
            }
        }
    }
}
