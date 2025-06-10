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
using System.Net.NetworkInformation;

namespace Proiect_EDU
{
    public partial class Vecini: Form
    {
        private int jocId;
        private int scor = 0;
        private string username;
        private int numarCurent;

        private bool gresitLaNumarulCurent = false; //pentru scor
        private List<int> numereDisponibile = new List<int>();
        
        private SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");

        public Vecini(int id, string user)
        {
            InitializeComponent();
            jocId = id;
            username = user;
        }

        private void GenereazaExercitiu()
        {
            if (numereDisponibile.Count > 0) {
                numarCurent = numereDisponibile[0]; //primul numar din lista

                lblNumar.Text = $"{numarCurent}";
                txtVecinStanga.Text = "";
                txtVecinDreapta.Text = "";

                numereDisponibile.RemoveAt(0);  //eliminam primul nr din lista
                gresitLaNumarulCurent = false; //resetam la inceputul fiecarui nr.
            }
        }
        private void Vecini_Load(object sender, EventArgs e)
        {
            IncarcaNumere();
            if(numereDisponibile.Count > 0)
            {
                GenereazaExercitiu();
            }
            else
            {
                this.Close();
            }
        }

        private void IncarcaNumere(){
            string query = "SELECT Numar FROM VeciniNumere WHERE JocId = @jocId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@jocId", jocId);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int numar = (int)reader["Numar"];
                    numereDisponibile.Add(numar);
                }
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Eroare" + ex.Message);
            }
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            string stangaText = txtVecinStanga.Text.Trim();
            string dreaptaText = txtVecinDreapta.Text.Trim();
            
            if (string.IsNullOrEmpty(stangaText) || string.IsNullOrEmpty(dreaptaText))
            {
                MessageBox.Show("Te rog sa completezi ambele campuri!");
                return;  // oprim aici, nu continuam
            }

            int stanga, dreapta;
            bool eStangaNumar = int.TryParse(stangaText, out stanga);
            bool eDreaptaNumar = int.TryParse(dreaptaText, out dreapta);

            if(!eStangaNumar || !eDreaptaNumar)
            {
                MessageBox.Show("Introdu doar numere intregi pozitive!");
                return;
            }

            /*verificam daca raspunsurile sunt corecte*/
            if(stanga == numarCurent - 1 && dreapta == numarCurent + 1)
            {
                if (!gresitLaNumarulCurent)
                {
                    scor++;
                }
                MessageBox.Show("Corect!");

                /*trecem la urmatorul numar*/
                if (numereDisponibile.Count > 0)
                {
                    GenereazaExercitiu();
                }
                else
                {
                    MessageBox.Show($"Ai terminat jocul! Scor: {scor}");
                }
            }
            else
            {
                MessageBox.Show("Gresit! Mai incearca o data!");
                gresitLaNumarulCurent = true;   //a gresit acest exercitiu, deci nu va creste scorul
            }
        }

        //private void SalveazaProgres()
        //{
        //    string query = "INSERT INTO ProgresJocuri(Username, JocId, DataFinalizarii, Scor) VALUES (@username, @jocId, @data, @scor)";
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    cmd.Parameters.AddWithValue("@username", username);
        //    cmd.Parameters.AddWithValue("@jocId", jocId);
        //    cmd.Parameters.AddWithValue("@data", DateTime.Now);
        //    cmd.Parameters.AddWithValue("@scor", scor);

        //    try
        //    {
        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //        conn.Close();
        //    }
        //    catch (Exception ex) {
        //        MessageBox.Show("Eroare" + ex.Message);
        //    }
        //}

        private void btnFinalizare_Click(object sender, EventArgs e)
        {
            DatabaseProgres progres = new DatabaseProgres();
            progres.MarcareProgresJoc(username, jocId, scor);
            this.Close();
        }
    }
}
