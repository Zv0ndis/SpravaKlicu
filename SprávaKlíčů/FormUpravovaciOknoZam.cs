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
    public partial class FormUpravovaciOknoZam : Form
    {
        Zamestnanec upravovany;
        public FormUpravovaciOknoZam(Zamestnanec zamestnanec)
        {
            InitializeComponent();
            upravovany = zamestnanec;
        }


        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUlozitZmeny_Click(object sender, EventArgs e)
        {
            upravovany.Jmeno = TBJmeno.Text;
            upravovany.Prijmeni = TBPrijmeni.Text;
            upravovany.Zkratka = TBZkratkaZamestnance.Text;

            using (SqlConnection connection = new SqlConnection(Data.connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Employees SET Name = @Name, Surname = @Surname, EShortcut = @Eshortcut WHERE Id = @ID", connection, transaction);
                    cmd.Parameters.AddWithValue("@Name", upravovany.Jmeno);
                    cmd.Parameters.AddWithValue("@Surname", upravovany.Prijmeni);
                    cmd.Parameters.AddWithValue("@EShortcut", upravovany.Zkratka);
                    cmd.Parameters.AddWithValue("@ID", upravovany.ID);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Chybka" + Environment.NewLine+ ex.Message);
                }
            }
            this.Close();
        }

        private void FormUpravovaciOknoZam_Load(object sender, EventArgs e)
        {
            TBJmeno.Text = upravovany.Jmeno;
            TBPrijmeni.Text = upravovany.Prijmeni;
            TBZkratkaZamestnance.Text = upravovany.Zkratka;
        }
    }
}
