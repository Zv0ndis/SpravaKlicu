using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Data.zamestnanci = LoadAllEmployees();


            Data.klice = LoadAllKeys();

            foreach (Zamestnanec zamestnanec in Data.zamestnanci)
            {
                comboBox2.Items.Add(zamestnanec);
            }

            comboBox2.Enabled = false;
            label2.Enabled = false;
            comboBox2.Visible = false;
            label2.Visible = false;


        }

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
                        Zamestnanec employee = new Zamestnanec(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(0));
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
                        Klic key = new Klic(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(0));
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

        private void button_prehled_vsech_zamestnancu_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            DataTable employees = employeeManager.GetAllEmployees();

            PrinterManager printerManager = new PrinterManager();
            printerManager.PrintEmployees(employees);
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
            printerPreview.PreviewKlíčeKolikZaměstnanců();
        }

        private void button_pocet_volnych_klicu_Click(object sender, EventArgs e)
        {
            printerPreview.PreviewVolnéKlíče();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    richTextBox1.Clear();
                    comboBox2.Enabled = false;
                    label2.Enabled = false;
                    comboBox2.Visible = false;
                    label2.Visible = false;

                    for (int i = Data.zamestnanci.Count - 1; i >= 0; i--)
                    {
                        Zamestnanec zamestnanec = Data.zamestnanci[i];
                        richTextBox1.AppendText($"{zamestnanec.ID}\n{zamestnanec.Jmeno}\n{zamestnanec.Prijmeni}\n{zamestnanec.Zkratka}\n");
                        richTextBox1.AppendText(Environment.NewLine);
                    }

                    break;


                case 1:

                    richTextBox1.Clear();

                    comboBox2.Enabled = true;
                    label2.Enabled = true;
                    comboBox2.Visible = true;
                    label2.Visible = true;


                    break;

                case 2:
                    richTextBox1.Clear();

                    comboBox2.Enabled = false;
                    label2.Enabled = false;
                    comboBox2.Visible = false;
                    label2.Visible = false;

                    foreach (Klic selectedKey in Data.klice)
                    {
                        DataTable dt = new DataTable();
                        using (SqlConnection connection = new SqlConnection(Data.connectionString))
                        {
                            query = @"
                SELECT 
                    e.Name AS EmployeeName,
                    e.Surname AS EmployeeSurname,
                    e.EShortcut AS EmployeeShortcut,
                    COUNT(*) AS NumberOfKeys
                FROM 
                    Employees e
                INNER JOIN 
                    BorrowedKeys bk ON e.Id = bk.Employee
                INNER JOIN 
                    Keys k ON bk.[Key] = k.Id
                WHERE 
                    k.Number = @KeyNumber
                GROUP BY 
                    e.Name, e.Surname, e.EShortcut";

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@KeyNumber", selectedKey.Cislo);
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            adapter.Fill(dt);
                        }

                        if (dt.Rows.Count > 0)
                        {
                            richTextBox1.AppendText($"Zaměstnanci s klíčem {selectedKey.Cislo}:");
                            richTextBox1.AppendText(Environment.NewLine);

                           
                            foreach (DataRow row in dt.Rows)
                            {
                                string employeeName = row["EmployeeName"].ToString();
                                string employeeSurname = row["EmployeeSurname"].ToString();
                                string employeeShortcut = row["EmployeeShortcut"].ToString();

                                richTextBox1.AppendText($"   {employeeName} {employeeSurname} ({employeeShortcut})");
                                richTextBox1.AppendText(Environment.NewLine);
                            }
                        }
                        else
                        {
                            richTextBox1.AppendText($"Žádný zaměstnanec nemá klíč {selectedKey.Cislo} půjčený.");
                            richTextBox1.AppendText(Environment.NewLine);
                        }
                    }
                    break;

                case 3:
                  
                    richTextBox1.Clear();
                    comboBox2.Enabled = false;
                    label2.Enabled = false;
                    comboBox2.Visible = false;
                    label2.Visible = false;


                    query = @"
                                 SELECT 
                                 k.Number AS KeyNumber,
                                 k.TypeOfRoom AS KeyType,
                                 k.DoorSign AS KeyDoorSign,
                                 (k.HowManyMade - ISNULL(k.HowManyBorrowed, 0)) AS FreeKeys,
                                 k.HowManyMade AS TotalKeys
                                 FROM 
                                 Keys k";

                    using (SqlConnection connection = new SqlConnection(Data.connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string keyNumber = reader["KeyNumber"].ToString();
                                int freeKeys = Convert.ToInt32(reader["FreeKeys"]);
                                int totalKeys = Convert.ToInt32(reader["TotalKeys"]);

                                string formattedKey = $"Klíč {keyNumber}: {freeKeys} / {totalKeys}";

                                richTextBox1.AppendText(formattedKey);
                                richTextBox1.AppendText(Environment.NewLine);
                            }
                        }
                    }
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            if (comboBox2.SelectedItem != null)
            {
                richTextBox1.Clear();

                int selectedEmployeeId = ((Zamestnanec)comboBox2.SelectedItem).ID;

                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(Data.connectionString))
                {
                    query = @"
            SELECT 
                k.Number AS KeyNumber,
                e.Name AS EmployeeName,
                e.Surname AS EmployeeSurname,
                e.EShortcut AS EmployeeShortcut
               FROM 
                 Employees e
                    INNER JOIN 
                     BorrowedKeys bk ON e.Id = bk.Employee
                    INNER JOIN 
                      Keys k ON bk.[Key] = k.Id
                     WHERE 
                       e.Id = @EmployeeId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    string employeeName = dt.Rows[0]["EmployeeName"].ToString();
                    string employeeSurname = dt.Rows[0]["EmployeeSurname"].ToString();
                    string employeeShortcut = dt.Rows[0]["EmployeeShortcut"].ToString();


                    Dictionary<string, int> keyCounts = new Dictionary<string, int>();

                    foreach (DataRow row in dt.Rows)
                    {
                        string keyNumber = row["KeyNumber"].ToString();
                        if (keyCounts.ContainsKey(keyNumber))
                        {
                            keyCounts[keyNumber]++;
                        }
                        else
                        {
                            keyCounts[keyNumber] = 1;
                        }
                    }

                    string employeeDetails = $"{employeeName} {employeeSurname}: počet klíčů {dt.Rows.Count}";
                    richTextBox1.AppendText(employeeDetails);
                    richTextBox1.AppendText(Environment.NewLine);

                    foreach (var kvp in keyCounts)
                    {
                        richTextBox1.AppendText($"   {kvp.Value}x Klíč {kvp.Key}");
                        richTextBox1.AppendText(Environment.NewLine);
                    }
                }
                else
                {
                    richTextBox1.AppendText("Žádné klíče nejsou půjčeny těmto zaměstnancem.");
                    richTextBox1.AppendText(Environment.NewLine);
                }
            }
        }
    }
}