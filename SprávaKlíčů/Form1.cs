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
            printerPreview = new PrinterManager();
        }

        private PrinterManager printerPreview;

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
                        Klic key = new Klic(reader.GetString(1),reader.GetString(2),reader.GetString(3),reader.GetInt32(4),reader.GetInt32(5),reader.GetInt32(0));
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
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnNahled_Click(object sender, EventArgs e)
        {

        }


        private void button_prehled_vsech_zamestnancu_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            DataTable employees = employeeManager.GetAllEmployees();

            PrinterManager printerManager = new PrinterManager();
            printerManager.PrintEmployees(employees);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }


        public class EmployeeManager
        {

            public DataTable GetAllEmployees()
            {
                DataTable dtEmployees = new DataTable();

                using (SqlConnection connection = new SqlConnection(Data.connectionString))
                {
                    string query = "SELECT * FROM Employees ORDER BY Surname";

                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dtEmployees);
                }

                return dtEmployees;
            }
        }


        private void button_prehled_zamestnancu_s_klicem_Click(object sender, EventArgs e)
        {
            printerPreview.PreviewEmployeesWithBorrowedKeys();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void button_pocet_volnych_klicu_Click(object sender, EventArgs e)
        {
           printerPreview.PreviewAvailableKeys();
        }
    }
}
