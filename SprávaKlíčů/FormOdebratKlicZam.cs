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
            if (ListboxZam.SelectedItem != null && ListboxKlice.SelectedItem != null)
            {
                int employeeId = Data.zamestnanci[ListboxZam.SelectedIndex].ID;
                int keyIndex = ListboxKlice.SelectedIndex;

                bool connectionExists = false;

                Klic selectedKey = null;

                try
                {

                    selectedKey = Data.klice[keyIndex];

                    using (SqlConnection connection = new SqlConnection(Data.connectionString))
                    {
                        connection.Open();


                        string checkConnectionQuery = @"SELECT COUNT(1) FROM [dbo].[BorrowedKeys] WHERE [Key] = @KeyId AND [Employee] = @EmployeeId";

                        SqlCommand command = new SqlCommand(checkConnectionQuery, connection);
                        command.Parameters.AddWithValue("@KeyId", selectedKey.ID);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            connectionExists = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při kontrole spojení: " + ex.Message);
                }

                if (connectionExists)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Data.connectionString))
                        {
                            connection.Open();


                            SqlTransaction transaction = connection.BeginTransaction();

                            try
                            {

                                string deleteQuery = @"DELETE TOP(1) FROM [dbo].[BorrowedKeys]
                                   WHERE [Key] = @KeyId AND [Employee] = @EmployeeId;";

                                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection, transaction);
                                deleteCommand.Parameters.AddWithValue("@KeyId", selectedKey.ID);
                                deleteCommand.Parameters.AddWithValue("@EmployeeId", employeeId);
                                deleteCommand.ExecuteNonQuery();

                                string updateQuery = @"UPDATE [dbo].[Keys]
                                   SET [HowManyBorrowed] = [HowManyBorrowed] - 1
                                   WHERE [Id] = @KeyId";

                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                                updateCommand.Parameters.AddWithValue("@KeyId", selectedKey.ID);
                                updateCommand.ExecuteNonQuery();


                                selectedKey.PocetVypujcenychKusu--;


                                transaction.Commit();

                                MessageBox.Show("Operace smazání byla úspěšná.");
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Chyba při mazání záznamu: " + ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Chyba při připojování k databázi: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Spojení mezi vybraným zaměstnancem a klíčem neexistuje.");
                }
            }
            else
            {
                MessageBox.Show("Prosím, vyberte zaměstnance a klíč.");
            }
        }

        private void FormOdebratKlicZam_Load(object sender, EventArgs e)
        {
            foreach (Zamestnanec zamestnanec in Data.zamestnanci)
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
