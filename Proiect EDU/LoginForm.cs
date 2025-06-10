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
    public partial class LoginForm : Form
    {
        //private AccountForm acc;
        private WelcomeForm welcome;
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(AccountForm acc, WelcomeForm welcome)
        {
            InitializeComponent();

            //pt a putea comunica cu alte form-uri
            //this.acc = acc;
            this.welcome = welcome;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //conectare la baza de date
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;

            try
            {
                string query = "SELECT * FROM Utilizatori WHERE Username = @username AND Parola = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    //verificam rolul utilizatorului
                    string rol = dtable.Rows[0]["Rol"].ToString();

                    //cand ut. se logheaza, salvam username-ul lui
                    WelcomeForm.username = username;    //pt a se transmite catre welcomeform
                    WelcomeForm.instance.fromLogin = true;

                    //transmitem informatia despre rol catre WelcomeForm
                    WelcomeForm.instance.SetAdminButtonVisibility(rol == "admin");

                    //salvam succesul autentificarii
                    AuditLogger logger = new AuditLogger();
                    logger.LogAction(username, "S-a logat in aplicatie!");


                    MessageBox.Show("Autentificare reusita!");
                    WelcomeForm.instance.ShowStartPanel();

                    this.Close();
                }
                else
                {
                    // salvam esecul autentificarii
                    AuditLogger logger = new AuditLogger();
                    logger.LogAction(username, "Tentativa esuata de autentificare");


                    MessageBox.Show("Eroare!");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch(Exception ex)
            {
                //adaugam in jurnal orice eroare care apare
                AuditLogger logger = new AuditLogger();
                logger.LogAction("Necunoscut", "Eroare la autentificare: " + ex.Message);

                MessageBox.Show("Eroare");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            welcome.ShowStartPanel();
        }
    }
}