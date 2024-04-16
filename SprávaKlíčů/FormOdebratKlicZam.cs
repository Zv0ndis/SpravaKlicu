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
                // Extract employee ID and key ID from selected listbox items
                int employeeId = Data.zamestnanci[ListboxZam.SelectedIndex].ID;
                int keyIndex = ListboxKlice.SelectedIndex;

                // Check if the connection exists
                bool connectionExists = false;

                // Initialize selectedKey
                Klic selectedKey = null;

                try
                {
                    // Assign the selectedKey
                    selectedKey = Data.klice[keyIndex];

                    using (SqlConnection connection = new SqlConnection(Data.connectionString))
                    {
                        connection.Open();

                        // Check if the connection exists in the BorrowedKeys table
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
                    MessageBox.Show("Error checking connection: " + ex.Message);
                }

                // If the connection exists, perform the delete operation and update HowManyBorrowed
                if (connectionExists)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Data.connectionString))
                        {
                            connection.Open();

                            // Begin a transaction
                            SqlTransaction transaction = connection.BeginTransaction();

                            try
                            {
                                // Delete the record from the BorrowedKeys table
                                string deleteQuery = @"DELETE TOP(1) FROM [dbo].[BorrowedKeys]
                                           WHERE [Key] = @KeyId AND [Employee] = @EmployeeId;";

                                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection, transaction);
                                deleteCommand.Parameters.AddWithValue("@KeyId", selectedKey.ID);
                                deleteCommand.Parameters.AddWithValue("@EmployeeId", employeeId);
                                deleteCommand.ExecuteNonQuery();

                                // Update HowManyBorrowed in the Keys table
                                string updateQuery = @"UPDATE [dbo].[Keys]
                                           SET [HowManyBorrowed] = [HowManyBorrowed] - 1
                                           WHERE [Id] = @KeyId";

                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                                updateCommand.Parameters.AddWithValue("@KeyId", selectedKey.ID);
                                updateCommand.ExecuteNonQuery();

                                // Decrement the PocetVypujcenychKusu property for the selected key
                                selectedKey.PocetVypujcenychKusu--;

                                // Commit the transaction
                                transaction.Commit();

                                MessageBox.Show("Delete operation successful.");
                            }
                            catch (Exception ex)
                            {
                                // Rollback the transaction if an error occurs
                                transaction.Rollback();
                                MessageBox.Show("Error deleting record: " + ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to database: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("The connection between the selected employee and key does not exist.");
                }
            }
            else
            {
                MessageBox.Show("Please select an employee and a key.");
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
