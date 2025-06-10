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
using System.Resources;

namespace Proiect_EDU
{
    public partial class RegisterForm : Form
    {
        private WelcomeForm parentForm;
        public RegisterForm(WelcomeForm form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            txtPasswordR.Clear();
            txtUsernameR.Clear();
            txtConfirmPasswordR.Clear();
            txtUsernameR.Focus();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username, password, email, confirmPassword;
            username = txtUsernameR.Text;
            password = txtPasswordR.Text;
            email = txtEmailR.Text;
            confirmPassword = txtConfirmPasswordR.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Parolele nu se potrivesc! Incearca din nou!");
                txtPasswordR.Clear();
                txtConfirmPasswordR.Clear();
                txtPasswordR.Focus();
                return;
            }

            try
            {
                string query = "SELECT COUNT(*) FROM Utilizatori WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                conn.Open();
                //ExecuteScalar = nr. de utilizatori care respecta query (folosit pt. contorizare)
                int useri = (int)cmd.ExecuteScalar();
                conn.Close();

                if (useri > 0)
                {
                    MessageBox.Show("Acest username este deja folosit! Te rog sa alegi altul.");
                    txtUsernameR.Clear();
                    txtPasswordR.Clear();
                    txtConfirmPasswordR.Clear();
                    txtEmailR.Clear();
                    txtPasswordR.Focus();
                }
                else
                {
                    //daca username-ul e disponibil, salvam utilizatorul in baza de date
                    string query2 = "INSERT INTO Utilizatori(Username, Parola, Email) VALUES (@username, @password, @email)";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@username", username);
                    cmd2.Parameters.AddWithValue("@password", password);
                    cmd2.Parameters.AddWithValue("@email", email);

                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();

                    // salvare in jurnal
                    AuditLogger logger = new AuditLogger();
                    logger.LogAction(username, "S-a inregistrat in aplicatie.");


                    MessageBox.Show("Inregistrare reusita!");

                    // incarcam direct LoginForm în mainpanel după inregistrare
                    parentForm.loadForm(new LoginForm(null, parentForm));
                }
            }
            catch(Exception ex)
            {
                // logare eroare
                AuditLogger logger = new AuditLogger();
                logger.LogAction("Necunoscut", "Eroare la inregistrare: " + ex.Message);

                MessageBox.Show("Eroare la inregistrare!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSterge_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            parentForm.ShowStartPanel();
        }
    }
}