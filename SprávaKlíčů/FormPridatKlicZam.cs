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
    public partial class FormPridatKlicZam : Form
    {
        public FormPridatKlicZam()
        {
            InitializeComponent();
        }

        private void BtnDat_Click(object sender, EventArgs e)
        {
            if (ListboxZam.SelectedItem != null && ListboxKlice.SelectedItem != null)
            {
                int employeeId = Data.zamestnanci[ListboxZam.SelectedIndex].ID;
                int keyIndex = ListboxKlice.SelectedIndex;
                Klic selectedKey = Data.klice[keyIndex];
                int keyId = selectedKey.ID;

                if (selectedKey.PocetVypujcenychKusu < selectedKey.PocetVyrobenychKusu)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Data.connectionString))
                        {
                            connection.Open();

                            string insertQuery = @"INSERT INTO [dbo].[BorrowedKeys] ([Key], [Employee], [DateOfBorrow]) 
                                           VALUES (@KeyId, @EmployeeId, GETDATE())";

                            SqlCommand command = new SqlCommand(insertQuery, connection);
                            command.Parameters.AddWithValue("@KeyId", keyId);
                            command.Parameters.AddWithValue("@EmployeeId", employeeId);
                            command.ExecuteNonQuery();

                            string updateQuery = @"UPDATE [dbo].[Keys] SET [HowManyBorrowed] = [HowManyBorrowed] + 1 WHERE [Id] = @KeyId";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@KeyId", keyId);
                            updateCommand.ExecuteNonQuery();

                            selectedKey.PocetVypujcenychKusu++;

                            MessageBox.Show("Operace spojení byla úspěšná.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Chyba při spojování ID: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Nelze půjčit další klíče. Všechny klíče jsou již vypůjčeny.");
                }
            }
            else
            {
                MessageBox.Show("Vyberte prosím zaměstnance a klíč.");
            }
        }

        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPridatKlicZam_Load(object sender, EventArgs e)
        {
            foreach( Zamestnanec zamestnanec in Data.zamestnanci)
            {
                ListboxZam.Items.Add($"{zamestnanec.Jmeno} {zamestnanec.Prijmeni}");
            }

            foreach (Klic klic in Data.klice)
            {
                ListboxKlice.Items.Add($"{klic.Cislo} {klic.NazevMistnosti} {klic.OznaceniDveri}");
            }
        }
    }
}
