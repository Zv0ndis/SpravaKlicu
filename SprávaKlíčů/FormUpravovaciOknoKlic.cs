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
    public partial class FormUpravovaciOknoKlic : Form
    {
        Klic upravovany;
        public FormUpravovaciOknoKlic(Klic klic)
        {
            InitializeComponent();
            upravovany = klic;
        }

        private void BtnUlozitZmeny_Click(object sender, EventArgs e)
        {
            upravovany.NazevMistnosti = TBNazevMistnosti.Text;
            upravovany.OznaceniDveri = TBOznaceniDveri.Text;

            if(Convert.ToInt32(TBPocetKlicuNaPocatku.Text) > upravovany.PocetVypujcenychKusu)
            {
                upravovany.PocetVyrobenychKusu = Convert.ToInt32(TBPocetKlicuNaPocatku.Text);

                using (SqlConnection connection = new SqlConnection(Data.connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Keys SET Number = @Number, TypeOfRoom = @TypeOfRoom, DoorSign = @DoorSign, HowManyMade = @HowManyMade WHERE Id = @ID", connection, transaction);
                        cmd.Parameters.AddWithValue("@Number", upravovany.Cislo);
                        cmd.Parameters.AddWithValue("@TypeOfRoom", upravovany. NazevMistnosti);
                        cmd.Parameters.AddWithValue("@DoorSign", upravovany.OznaceniDveri);
                        cmd.Parameters.AddWithValue("@ID", upravovany.ID);
                        cmd.Parameters.AddWithValue("@HowManyMade", upravovany.PocetVyrobenychKusu);
                        cmd.ExecuteNonQuery();

                        transaction.Commit();

                        upravovany.Cislo = MTBCislo.Text;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Došlo k chybě při aktualizaci klíče: " + ex.Message);
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Nemůže být víc klíčů zapůjčených než vyrobených na počátku");
            }


            
        }

        private void BtnZrusit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpravovaciOknoKlic_Load(object sender, EventArgs e)
        {
            MTBCislo.Text = upravovany.Cislo;
            TBNazevMistnosti.Text = upravovany.NazevMistnosti;
            TBOznaceniDveri.Text = upravovany.OznaceniDveri;
            TBPocetKlicuNaPocatku.Text = upravovany.PocetVyrobenychKusu.ToString();
        }
    }
}
