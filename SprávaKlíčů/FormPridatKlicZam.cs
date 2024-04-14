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
            // Zkontrolujte, zda jsou vybrány položky v obou seznamových polích
            if (ListboxZam.SelectedItem != null && ListboxKlice.SelectedItem != null)
            {
                // Extrahování ID zaměstnance a ID klíče z vybraných položek v seznamových polích
                int employeeId = Data.zamestnanci[ListboxZam.SelectedIndex].ID;
                int keyIndex = ListboxKlice.SelectedIndex;
                Klic selectedKey = Data.klice[keyIndex];
                int keyId = selectedKey.ID;

                // Zkontrolujte, zda se nemůže půjčit více klíčů, než bylo vyrobeno
                if (selectedKey.PocetVypujcenychKusu < selectedKey.PocetVyrobenychKusu)
                {
                    // Proveďte operaci spojení
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(Data.connectionString))
                        {
                            connection.Open();

                            // Vložte ID zaměstnance a ID klíče do tabulky BorrowedKeys
                            string insertQuery = @"INSERT INTO [dbo].[BorrowedKeys] ([Key], [Employee], [DateOfBorrow]) 
                                           VALUES (@KeyId, @EmployeeId, GETDATE())";

                            SqlCommand command = new SqlCommand(insertQuery, connection);
                            command.Parameters.AddWithValue("@KeyId", keyId);
                            command.Parameters.AddWithValue("@EmployeeId", employeeId);
                            command.ExecuteNonQuery();

                            // Inkrementujte počet vypůjčených klíčů pro vybraný klíč
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
