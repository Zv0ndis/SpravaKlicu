using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SprávaKlíčů
{
    public partial class FormPridatNovehoZam : Form
    {
        public FormPridatNovehoZam()
        {
            InitializeComponent();
        }



        private void BtnPridat_Click(object sender, EventArgs e)
        {
            Zamestnanec Aktualni = new Zamestnanec(TBJmeno.Text, TBPrijmeni.Text, TBZkratkaZamestnance.Text,Data.zamestnanci.Count>0 ? Data.zamestnanci[Data.zamestnanci.Count-1].ID+1 : 1 );
            Data.zamestnanci.Add(Aktualni);
            using (SqlConnection connection = new SqlConnection(Data.connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Employees(Name,Surname,EShortcut) VALUES (@Name, @Surname, @EShortcut)",connection,transaction);
                    cmd.Parameters.AddWithValue("@Name", Aktualni.Jmeno);
                    cmd.Parameters.AddWithValue("@Surname", Aktualni.Prijmeni);
                    cmd.Parameters.AddWithValue("@EShortcut", Aktualni.Zkratka);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Chybka" + ex.Message);
                }
            }

            this.Close();
        }

        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
