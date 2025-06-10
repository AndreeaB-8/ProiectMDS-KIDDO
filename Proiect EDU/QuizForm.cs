using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_EDU
{
    public partial class QuizForm : Form
    {
        private class Intrebare
        {
            public string Text { get; set; }
            public string A { get; set; }
            public string B { get; set; }
            public string C { get; set; }
            public string D { get; set; }
            public string Corect { get; set; }
        }

        private int jocId;
        private int index = 0;
        private int scor = 0;
        private List<Intrebare> intrebari;
        private string username;    /*pentru salvarea progresului*/

        private bool gresitLaNumarulCurent = false; //pentru scor

        private SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");
        public QuizForm(int id, string user)
        {
            InitializeComponent();
            jocId = id;
            username = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            IncarcareIntrebari();
            AfisareIntrebare();
        }

        private void IncarcareIntrebari()
        {
            intrebari = new List<Intrebare>();

            string query = "SELECT * FROM Intrebari WHERE JocId = @jocId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@jocId", jocId);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    intrebari.Add(new Intrebare //adaugam intrebarile in lista de intrebari
                    {
                        Text = reader["Text"].ToString(),
                        A = reader["VariantaA"].ToString(),
                        B = reader["VariantaB"].ToString(),
                        C = reader["VariantaC"].ToString(),
                        D = reader["VariantaD"].ToString(),
                        Corect = reader["RaspunsCorect"].ToString()
                    });
                }
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Eroare!" + ex.Message);
            }
        }
        private void AfisareIntrebare()
        {
            if(index >= intrebari.Count)
            {
                MessageBox.Show("Felicitari! Ai terminat quiz-ul! Scor final: " + scor + "/" + intrebari.Count);
                return;
            }

            var q = intrebari[index];   //obtinem intrebarea de pe poz. index
            lblIntrebare.Text = q.Text;
            btnA.Text = q.A;
            btnB.Text = q.B;
            btnC.Text = q.C;
            btnD.Text = q.D;

            gresitLaNumarulCurent = false;
        }

        private void VerificaRaspuns(string alegere)
        {
            if (intrebari[index].Corect == alegere)
            {
                if (!gresitLaNumarulCurent)
                {
                    scor++;
                }
                MessageBox.Show("Corect!");

                //daca raspunsul este corect se trece la urm. intrebare
                index++;
                AfisareIntrebare();
            }
            else
            {
                MessageBox.Show("Gresit! Mai incearca o data!");
                gresitLaNumarulCurent = true;   //pt a nu creste scorul daca ut. raspunde corect din a doua incercare
            }
        }


        private void lblIntrebare_Click(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            VerificaRaspuns("A");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            VerificaRaspuns("B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            VerificaRaspuns("C");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            VerificaRaspuns("D");
        }

        private void btnFinalizare_Click(object sender, EventArgs e)
        {
            DatabaseProgres progres = new DatabaseProgres();
            progres.MarcareProgresJoc(username, jocId, scor);
            this.Close();
        }

        private void QuizForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
