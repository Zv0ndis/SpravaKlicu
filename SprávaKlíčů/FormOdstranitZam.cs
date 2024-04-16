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
    public partial class FormOdstranitZam : Form
    {
        public FormOdstranitZam()
        {
            InitializeComponent();
        }

        private void BtnOdstranitOK_Click(object sender, EventArgs e)
        {
            if(ListboxZam.SelectedIndex >-1)
            {
                using (SqlConnection connection = new SqlConnection(Data.connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE ID = @ID", connection, transaction);
                        cmd.Parameters.AddWithValue("@ID", Data.zamestnanci[ListboxZam.SelectedIndex].ID);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        Data.zamestnanci.Remove(Data.zamestnanci[ListboxZam.SelectedIndex]);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Došlo k chybě při odstraňování zaměstnance: " + Environment.NewLine + ex.Message);
                    }
                }
            }
            this.Close();
        }

        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOdstranitZam_Load(object sender, EventArgs e)
        {
            foreach(Zamestnanec zamestnanec in Data.zamestnanci)
            {
                ListboxZam.Items.Add($"{zamestnanec.Jmeno} {zamestnanec.Prijmeni}");
            }
        }
    }
}
