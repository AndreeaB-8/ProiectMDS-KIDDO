using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_EDU
{
    
    public partial class ClassForm : Form
    {
        private string username;
        private WelcomeForm parent; //retinem instanta welcomeForm pentru butonul de Inapoi
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");

        //eveniment care anunta selectarea unei clase
        public event EventHandler<Tuple<int, string>> ClasaSelectata;

        public ClassForm(WelcomeForm parentForm, string user)
        {
            InitializeComponent();

            //pentru glitch-ul de fundal
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            
            parent = parentForm;
            username = user;
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            IncarcaClase();
        }

        private void IncarcaClase()
        {
            try
            {
                listBoxClase.Items.Clear();
                string query = "SELECT Nume, Id FROM Clase";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())   //citim clasele si le afisam in listBox
                {
                    listBoxClase.Items.Add(reader["Nume"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare " + ex.Message);
            }
        }

        //evenimentul care se declanseaza atunci cand o clasa este selectata din ListBox
        private void listBoxClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClase.SelectedIndex >= 0)
            {
                //obtinem clasa selectata de utilizator
                string clasaNume = listBoxClase.SelectedItem.ToString();
                //obtinem id-ul clasei din bd
                int clasaID = GetIdClasa(clasaNume);
          
                //cream si adaugam subjectsForm
                parent.mainpanel.Controls.Clear();

                //transmitem si parent.mainpanel pt a se afisa in acelasi mainpanel
                SubjectsForm subjectform = new SubjectsForm(clasaID, clasaNume, parent.mainpanel, username);
                subjectform.TopLevel = false;
                subjectform.Dock = DockStyle.Fill;
                parent.mainpanel.Controls.Add(subjectform);
                subjectform.Show();
            }
            else
            {
                MessageBox.Show("Nicio clasa selectata!");
            }
        }

        //pentru a obtine id-ul clasei din bd
        private int GetIdClasa(string clasaNume)
        {
            int clasaID = 0;
            try
            {
                string query = "SELECT Id from Clase WHERE Nume = @Nume";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nume", clasaNume);    //transmitem val. efectiva pt parametrul @Nume

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    clasaID = (int)reader["Id"];    //citim valoarea din "Id" si o salvam in clasaID
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare!" + ex.Message);
            }
            return clasaID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            //luam form-ul parinte, care a deschis ClassForm
            WelcomeForm parent = this.ParentForm as WelcomeForm;
            if (parent != null)
            {
                parent.mainpanel.Controls.Clear();
                parent.mainpanel.Controls.Add(parent.panelStart);   //adaugam din nou panoul start in zona principala
                parent.panelStart.Dock = DockStyle.Fill;
                parent.panelStart.Visible = true;

            }
        }
    }
}
