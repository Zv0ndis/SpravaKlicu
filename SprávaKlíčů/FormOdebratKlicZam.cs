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
            // Check if both listboxes have selected items
            if (ListboxZam.SelectedItem != null && ListboxKlice.SelectedItem != null)
            {
                // Extract employee ID and key ID from selected listbox items
                int employeeId = Data.zamestnanci[ListboxZam.SelectedIndex].ID;
                int keyId = Data.klice[ListboxKlice.SelectedIndex].ID;

                // Check if the connection exists
                bool connectionExists = false;

                try
                {
                    using (SqlConnection connection = new SqlConnection(Data.connectionString))
                    {
                        connection.Open();

                        // Check if the connection exists in the BorrowedKeys table
                        string checkConnectionQuery = @"SELECT COUNT(*) FROM [dbo].[BorrowedKeys] WHERE [Key] = @KeyId AND [Employee] = @EmployeeId";

                        SqlCommand command = new SqlCommand(checkConnectionQuery, connection);
                        command.Parameters.AddWithValue("@KeyId", keyId);
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

                // If the connection exists, perform the delete operation
                if (connectionExists)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Data.connectionString))
                        {
                            connection.Open();

                            // Delete the record from the BorrowedKeys table
                            string deleteQuery = @"DELETE FROM [dbo].[BorrowedKeys] WHERE [Key] = @KeyId AND [Employee] = @EmployeeId";

                            SqlCommand command = new SqlCommand(deleteQuery, connection);
                            command.Parameters.AddWithValue("@KeyId", keyId);
                            command.Parameters.AddWithValue("@EmployeeId", employeeId);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Delete operation successful.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
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
