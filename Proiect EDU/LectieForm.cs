using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_EDU
{
    public partial class LectieForm: Form
    {
        private int lectieId;
        private string username;
        private SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");

        public LectieForm(int id, string user)
        {
            InitializeComponent();
            lectieId = id;
            username = user;    /*pt marcarea progresului*/
        }

        private void LectieForm_Load(object sender, EventArgs e)
        {
            IncarcareLectie();
        }

        private void IncarcareLectie() {
            string query = "SELECT Titlu, Continut FROM Lectii WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", lectieId);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblTitlu.Text = reader["Titlu"].ToString();
                    txtContinut.Text = reader["Continut"].ToString();
                }
                else
                {
                    MessageBox.Show("Lectia nu a fost gasita!");
                }
                conn.Close();
            }
            catch (Exception ex) { 
                MessageBox.Show("Eroare" + ex.Message);
            }
            
        }

        private void lblTitlu_Click(object sender, EventArgs e)
        {

        }

        private void txtContinut_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContinut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFinalizare_Click(object sender, EventArgs e)
        {
            DatabaseProgres progres = new DatabaseProgres();    //ut. apasa pe finlizare => marcam progresul
            progres.MarcareProgresLectie(username, lectieId);
            this.Close();
        }
    }
}
