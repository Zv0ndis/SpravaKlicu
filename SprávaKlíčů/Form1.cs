using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprávaKlíčů
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Načtení všech zaměstnanců
            Data.zamestnanci = LoadAllEmployees();

            // Načtení všech klíčů
            Data.klice = LoadAllKeys();
        }

        // Metoda pro načtení všech zaměstnanců
        private List<Zamestnanec> LoadAllEmployees()
        {
            List<Zamestnanec> employees = new List<Zamestnanec>();

            using (SqlConnection connection = new SqlConnection(Data.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Employees", connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Zamestnanec employee = new Zamestnanec(reader.GetString(1),reader.GetString(2),reader.GetString(3), reader.GetInt32(0));
                        employees.Add(employee);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při načítání zaměstnanců: " + ex.Message);
                }
            }

            return employees;
        }

        // Metoda pro načtení všech klíčů
        private List<Klic> LoadAllKeys()
        {
            List<Klic> keys = new List<Klic>();

            using (SqlConnection connection = new SqlConnection(Data.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Keys", connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Klic key = new Klic(reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetInt32(3),reader.GetInt32(4));
                        keys.Add(key);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při načítání klíčů: " + ex.Message);
                }
            }

            return keys;
        }

        private void button_pridat_noveho_zamestnance_Click(object sender, EventArgs e)
        {
            FormPridatNovehoZam form = new FormPridatNovehoZam();
            form.Show();
        }

        private void button_upravit_zamestnance_Click(object sender, EventArgs e)
        {
            FormUpravitZam form = new FormUpravitZam();
            form.Show();
        }

        private void button_odstranit_zamestnance_Click(object sender, EventArgs e)
        {
            FormOdstranitZam form = new FormOdstranitZam();
            form.Show();
        }

        private void button_pridat_klic_Click(object sender, EventArgs e)
        {
            FormPridatNovyKlic form = new FormPridatNovyKlic();
            form.Show();
        }

        private void button_upravit_klic_Click(object sender, EventArgs e)
        {
            FormUpravitKlic form = new FormUpravitKlic();
            form.Show();
        }

        private void button_odstranit_klic_Click(object sender, EventArgs e)
        {
            FormOdstranitKlic form = new FormOdstranitKlic();
            form.Show();
        }

        private void button_priradit_klic_zamestnanci_Click(object sender, EventArgs e)
        {
            FormPridatKlicZam form = new FormPridatKlicZam();
            form.Show();
        }

        private void button_odebrat_klic_zamestnanci_Click(object sender, EventArgs e)
        {
            FormOdebratKlicZam form = new FormOdebratKlicZam();
            form.Show();
        }

        private void button_prehled_klicu_zamestnance_Click(object sender, EventArgs e)
        {
            FormVybereZamProPrehled form = new FormVybereZamProPrehled();
            form.Show();
        }

        private void BtnTisk_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(PrintPage);
            printDialog1.Document = printDocument1;

            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Font pro nadpisy
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            // Font pro normální text
            Font normalFont = new Font("Arial", 12);

            // Zde můžete definovat data pro každý přehled
            string overviewTitle = "Přehledy aplikace";
            string overviewText = "";

            //// Podle uživatelova výběru zobrazíme odpovídající data
            //switch (selectedOverview)
            //{
            //    case Overview.AllEmployees:
            //        overviewText = GenerateAllEmployeesOverview();
            //        break;
            //    case Overview.KeysCount:
            //        overviewText = GenerateKeysCountOverview();
            //        break;
            //    case Overview.EmployeeKeys:
            //        overviewText = GenerateEmployeeKeysOverview(selectedEmployee);
            //        break;
            //    case Overview.KeyEmployees:
            //        overviewText = GenerateKeyEmployeesOverview(selectedKey);
            //        break;
            //    case Overview.FreeKeys:
            //        overviewText = GenerateFreeKeysOverview();
            //        break;
            //}

            // Pozice pro kreslení textu na tiskové stránce
            float yPos = 100;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            // Kreslení nadpisu
            e.Graphics.DrawString(overviewTitle, titleFont, Brushes.Black, leftMargin, yPos);
            yPos += titleFont.GetHeight();

            // Kreslení textu přehledu
            e.Graphics.DrawString(overviewText, normalFont, Brushes.Black, leftMargin, yPos);

            // Kontrola, zda jsou další stránky k tisku
            e.HasMorePages = true; // Změňte na true, pokud má být k dispozici další stránka
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void BtnNahled_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        // Metoda pro generování přehledu všech zaměstnanců
        private string GenerateAllEmployeesOverview()
        {
            StringBuilder overview = new StringBuilder();
            overview.AppendLine("Přehled všech zaměstnanců (seřazený podle příjmení):");
            //foreach (Zamestnanec employee in GetAllEmployeesSortedByLastName())
            //{
            //    overview.AppendLine(employee.Prijmeni + ", " + employee.Jmeno);
            //}
            return overview.ToString();
        }

        // Metoda pro generování přehledu počtu klíčů, které mají zaměstnanci vypůjčené
        private string GenerateKeysCountOverview()
        {
            StringBuilder overview = new StringBuilder();
            overview.AppendLine("Počet klíčů, které mají zaměstnanci vypůjčené:");
            //foreach (Zamestnanec employee in GetAllEmployees())
            //{
            //    int keysCount = GetEmployeeKeysCount(employee);
            //    overview.AppendLine(employee.Prijmeni + ", " + employee.Jmeno + ": " + keysCount);
            //}
            return overview.ToString();
        }

        // Metoda pro generování přehledu všech vypůjčených klíčů konkrétního zaměstnance
        private string GenerateEmployeeKeysOverview(Zamestnanec employee)
        {
            //StringBuilder overview = new StringBuilder();
            //overview.AppendLine("Výpis všech vypůjčených klíčů zaměstnance " + employee.LastName + ", " + employee.FirstName + ":");
            ////foreach (Klic key in GetEmployeeKeys(employee))
            //{
            //    overview.Append(" ID klíče: " + key.Cislo + ", Popis: " + key.NazevMistnosti);
            //}
            //return overview.ToString();
            return null;
        }

        // Metoda pro generování přehledu všech zaměstnanců, kteří mají konkrétní klíč vypůjčený
        private string GenerateKeyEmployeesOverview(Klic key)
        {
            StringBuilder overview = new StringBuilder();
            //overview.AppendLine("Výpis všech zaměstnanců, kteří mají klíč " + key.Cislo + " vypůjčený:");
            //foreach (Zamestnanec employee in GetKeyEmployees(key))
            //{
            //    overview.AppendLine(employee.Prijmeni + ", " + employee.Jmeno);
            //}
            return overview.ToString();
        }

        // Metoda pro generování přehledu volných klíčů
        private string GenerateFreeKeysOverview()
        {
            StringBuilder overview = new StringBuilder();
            overview.AppendLine("Výpis volných klíčů:");
            //foreach (Klic key in GetAllKeys())
            //{
            //    int availableKeys = GetAvailableKeysCount(key);
            //    int totalKeys = GetTotalKeysCount(key);
            //    overview.AppendLine("Číslo klíče: " + key.Cislo + ", Počet volných klíčů: " + availableKeys + "/" + totalKeys);
            //}
            return overview.ToString();
        }

    }
}
