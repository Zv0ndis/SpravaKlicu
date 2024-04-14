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
    public partial class FormPridatNovyKlic : Form
    {
        public FormPridatNovyKlic()
        {
            InitializeComponent();
        }

        private void BtnPridat_Click(object sender, EventArgs e)
        {
            Klic Aktualni = new Klic(MTBCislo.Text, TBNazevMistnosti.Text, TBOznaceniDveri.Text,Convert.ToInt32(TBPocetKlicuNaPocatku.Text),0);
            Data.klice.Add(Aktualni);

            using (SqlConnection connection = new SqlConnection(Data.connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Keys(Id,TypeOfRoom,DoorSign,HowManyMade) VALUES (@Id,@TypeOfRoom,@DoorSign,@HowManyMade)", connection, transaction);
                    cmd.Parameters.AddWithValue("@Id", Aktualni.Cislo);
                    cmd.Parameters.AddWithValue("@TypeOfRoom", Aktualni.NazevMistnosti);
                    cmd.Parameters.AddWithValue("@DoorSign", Aktualni.OznaceniDveri);
                    cmd.Parameters.AddWithValue("@HowManyMade", Aktualni.PocetVyrobenychKusu);
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
