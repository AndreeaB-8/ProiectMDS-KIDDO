using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proiect_EDU
{
    public class DatabaseProgres
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");
       
        //salveaza progresul unui utilizator la o lectie
        public void MarcareProgresLectie(string username, int lectieId)
        {
            try
            {
                string query = "INSERT INTO ProgresLectii(Username, LectieId, DataFinalizarii)" +
                               "VALUES (@username, @lectieId, @dataFinalizarii)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@lectieId", lectieId);
                cmd.Parameters.AddWithValue("@dataFinalizarii", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare" + ex.Message);
            }
        }

        //salveaza progresul unui utilizator la un joc
        public void MarcareProgresJoc(string username, int jocId, int scor)
        {
            try
            {
                string query = "INSERT INTO ProgresJocuri(Username, JocId, DataFinalizarii, Scor)" +
                               "VALUES (@username, @jocId, @dataFinalizarii, @scor)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@jocId", jocId);
                cmd.Parameters.AddWithValue("@dataFinalizarii", DateTime.Now);
                cmd.Parameters.AddWithValue("@scor", scor);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare" + ex.Message);
            }
        }

        //verifica daca progresul lectiei exista in bd
        public bool VerificaProgresLectie(string username, int lectieId)
        {
            bool progresFinalizat = false;
            try
            {
                string query = "SELECT COUNT(*) FROM ProgresLectii WHERE Username = @username AND LectieId = @lectieId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@lectieId", lectieId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                progresFinalizat = count > 0; //daca exista inregistrare, progresul este marcat ca finalizat
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare: " + ex.Message);
            }
            return progresFinalizat;
        }

        //verifica daca progresul jocului exista in bd
        public bool VerificaProgresJoc(string username, int jocId)
        {
            bool progresFinalizat = false;
            try
            {
                string query = "SELECT COUNT(*) FROM ProgresJocuri WHERE Username = @username AND JocId = @jocId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@jocId", jocId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                progresFinalizat = count > 0; //daca exista inregistrare, progresul este marcat ca finalizat
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare: " + ex.Message);
            }
            return progresFinalizat;
        }

    }
}
