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
    public partial class SubjectsForm: Form
    {
        private Panel parentPanel;  //retinem panel ul unde se va afisa urm. formular
        private int clasaID;
        private string clasaNume;
        private string username;

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");
        public SubjectsForm(int id, string nume, Panel panel, string user)
        {
            InitializeComponent();

            //pentru glitch-ul de fundal
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            clasaID = id;
            clasaNume = nume;
            parentPanel = panel;    //panoul unde va fi incarcat
            username = user;
        }

        //aflam id-ul materiei selectate
        private int GetIdMaterie(string numeMaterie) {
            int id = 0;
            try
            {
                string query = "SELECT Id from Materii WHERE Nume = @nume";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nume", numeMaterie);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    id = (int)reader["Id"]; //salvam in id id-ul clasei din bd
                }
                conn.Close();
            }
            catch(Exception ex) {
                MessageBox.Show("Eroare " + ex.Message);
            }
            return id;
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            IncarcaMaterii();
        }

        //incarcam materiile din bd in lista noastra
        private void IncarcaMaterii()
        {
            try
            {
                listBoxMaterii.Items.Clear();
                string query = "SELECT Nume from Materii";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {     //pt fiecare materie, adaugam numele
                    listBoxMaterii.Items.Add(reader["Nume"].ToString());        
                }
                conn.Close();
            }
            catch(Exception ex) {
                MessageBox.Show("Eroare " + ex.Message);
            }
        }

        private void listBoxMaterii_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMaterii_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxMaterii.SelectedItem != null)
            {
                string numeMaterie = listBoxMaterii.SelectedItem.ToString();
                int materieId = GetIdMaterie(numeMaterie);

                parentPanel.Controls.Clear();

                //alegem materia si deschidem form-ul cu cele 2 butoane: Lectii si Jocuri
                LectiiJocuri lectiiForm = new LectiiJocuri(materieId, numeMaterie, clasaID, parentPanel, username);
                
                //aici transmitem clasa si materia alese de utilizator catre lectiijocuri
                lectiiForm.TopLevel = false;
                lectiiForm.Dock = DockStyle.Fill;
                parentPanel.Controls.Add(lectiiForm);
                lectiiForm.Show();
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            //luam form-ul parinte, care a deschis SubjectsForm, si il convertim la WelcomeForm
            WelcomeForm parent = this.ParentForm as WelcomeForm;
            if (parent != null)
            {
                parent.mainpanel.Controls.Clear();

                ClassForm clasa = new ClassForm(parent, username);  //incarcam inapoi classform pt a reselecta o clasa
                clasa.TopLevel = false;
                clasa.Dock = DockStyle.Fill;
                parent.mainpanel.Controls.Add(clasa);
                clasa.Show();
            }
        }
    }
}
