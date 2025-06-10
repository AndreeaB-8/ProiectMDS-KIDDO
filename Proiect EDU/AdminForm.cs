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
using System.IO;    //pentru File.Exists

//pt PDF
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Font.Constants;
using iText.Kernel.Font;

namespace Proiect_EDU
{
    public partial class AdminForm: Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            IncarcaUtilizatori();
        }

        //conectare la baza de date
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");

        private void IncarcaUtilizatori()
        {
            try
            {
                //daca conexiunea ramane deschisa, o inchidem
                if (conn.State == ConnectionState.Open) conn.Close();

                conn.Open();
                string query = "SELECT Username, Parola, Email, Rol FROM Utilizatori";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                dataGridViewUtilizatori.DataSource = dtable;
            }
            catch (Exception ex) {
                MessageBox.Show("Eroare" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAdaugaUtilizator_Click(object sender, EventArgs e)
        {
            string username = txtNume.Text.Trim();
            string parola = txtParola.Text.Trim();
            string email = txtEmail.Text.Trim();
            string rol = cbRol.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(parola) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Completeaza toate campurile.");
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();

                conn.Open();
                string query = "INSERT INTO Utilizatori (Username, Parola, Email, Rol) VALUES (@username, @parola, @email, @rol)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@parola", parola);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@rol", rol);

                //salvarea actiunii
                if (conn.State == ConnectionState.Open) conn.Close();
                AuditLogger logger = new AuditLogger();
                logger.LogAction("Admin", $"A adaugat utilizatorul '{username}' cu rolul '{rol}'.");


                cmd.ExecuteNonQuery();
                MessageBox.Show("Utilizator adaugat!");
                IncarcaUtilizatori();

                //golim campurile dupa ce se adauga utilizatorul
                txtNume.Text = "";
                txtParola.Text = "";
                txtEmail.Text = "";
                cbRol.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Eroare" + ex.Message);

                if (conn.State == ConnectionState.Open) conn.Close();
                AuditLogger logger = new AuditLogger();
                logger.LogAction("Admin", $"Eroare la adaugare utilizator '{username}': {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnStergeUtilizator_Click(object sender, EventArgs e)
        {
            if (dataGridViewUtilizatori.SelectedRows.Count == 0) {
                MessageBox.Show("Alege un utilizator.");
                return;
            }

            //preluam username-ul utilizatorului dorit de admin
            string username = dataGridViewUtilizatori.SelectedRows[0].Cells["Username"].Value.ToString();
            
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();

                conn.Open();
                string query = "DELETE FROM Utilizatori WHERE Username = @username";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                //salvarea actiunii
                if (conn.State == ConnectionState.Open) conn.Close();
                AuditLogger logger = new AuditLogger();
                logger.LogAction("Admin", $"A sters utilizatorul '{username}'.");


                cmd.ExecuteNonQuery();
                MessageBox.Show("Utilizator sters cu succes!");
                IncarcaUtilizatori();   //actualizam utilizatorii
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare" + ex.Message);

                if (conn.State == ConnectionState.Open) conn.Close();
                AuditLogger logger = new AuditLogger();
                logger.LogAction("Admin", $"Eroare la stergere utilizator '{username}': {ex.Message}");

            }
            finally { 
                conn.Close();
            }
        }

        private void btnEditeazaUtilizator_Click(object sender, EventArgs e)
        {
            if (dataGridViewUtilizatori.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteaza un utilizator din tabel.");
                return;
            }
                
            string username = dataGridViewUtilizatori.SelectedRows[0].Cells["Username"].Value.ToString();
            string parola = txtParola.Text.Trim();
            string email = txtEmail.Text.Trim();
            string rol = cbRol.SelectedItem?.ToString();

            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();

                conn.Open();
                string query = "UPDATE Utilizatori SET Parola = @parola, Email = @email, Rol = @rol WHERE Username = @username";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@parola", parola);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@username", username);

                //salvarea actiunii
                if (conn.State == ConnectionState.Open) conn.Close();
                AuditLogger logger = new AuditLogger();
                logger.LogAction("Admin", $"A modificat utilizatorul '{username}' (email: {email}, rol: {rol}).");


                cmd.ExecuteNonQuery();
                MessageBox.Show("Utilizator actualizat cu succes!");
                IncarcaUtilizatori();
            }
            catch (Exception ex) {
                MessageBox.Show("Eroare" + ex.Message);

                if (conn.State == ConnectionState.Open) conn.Close();
                AuditLogger logger = new AuditLogger();
                logger.LogAction("Admin", $"Eroare la modificare utilizator '{username}': {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        //cand se selecteaza un rand, campurile se completeaza automat cu datele utilizatorului
        private void dataGridViewUtilizatori_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewUtilizatori.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewUtilizatori.SelectedRows[0];

                txtNume.Text = row.Cells["Username"].Value.ToString();
                txtParola.Text = row.Cells["Parola"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cbRol.SelectedItem = row.Cells["Rol"].Value.ToString();
            }
        }

        private void btnGenereazaRaport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog(); 
                saveDialog.Filter = "CSV Files|*.csv";  //tipul de fisier care poate fi salvat in savedialog
                saveDialog.Title = "Salveaza raportul CSV"; //titlul ferestrei de dialog
                saveDialog.FileName = "Raport_Utilizatori.csv"; //numele implicit al fisierului

                if (saveDialog.ShowDialog() == DialogResult.OK) //daca ut. apasa pe OK(Salvare)
                {
                    string filePath = saveDialog.FileName;  //calea completa a raportului pe care dorim sa-l salvam


                    //FOLOSIM STREAMWRITER PENTRU A SCRIE FISIERUL!
                    //cream un obiect StreamWriter care scrie datele in fisierul selectat de admin
                    //false = fisierul va fi suprascris daca exista deja
                    using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        // extrage titlurile coloanelor din datagridviewutilizatorii si le pune intr-o lista
                        var headers = dataGridViewUtilizatori.Columns   //coloanele
                            .Cast<DataGridViewColumn>() //converteste el. din colectia de coloane la tipul datagridviewcolumn
                            .Select(c => c.HeaderText); //selectam doar titlurile coloanelor
                        sw.WriteLine(string.Join(";", headers));    //le separam prin ';'

                        // scriem datele
                        foreach (DataGridViewRow row in dataGridViewUtilizatori.Rows)
                        {
                            if (!row.IsNewRow)  //daca randul nu e gol
                            {
                                //extragem valorile fiecarei celule din randul curent
                                var cells = row.Cells.Cast<DataGridViewCell>()
                                    .Select(c => c.Value?.ToString()?.Replace(";", " ") ?? ""); //pt fiecare cellula c luam valoarea si punem ; (e separator de coloana in CSV)
                                sw.WriteLine(string.Join(";", cells));
                            }
                        }
                    }

                    MessageBox.Show("Raport CSV generat cu succes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }


    }
}
