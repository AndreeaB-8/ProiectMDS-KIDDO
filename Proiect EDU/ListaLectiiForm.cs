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

namespace Proiect_EDU
{
    public partial class ListaLectiiForm: Form
    {
        private Panel parentPanel; //retinem panel ul unde se va afisa urm. formular
        private int materieId;
        private int clasaId;
        private string username;

        private SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");

        public ListaLectiiForm(int mId, int cId, Panel panel, string user)
        {
            InitializeComponent();
            //pentru glitch-ul de fundal
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            materieId = mId;
            clasaId = cId;
            parentPanel = panel;
            username = user;
        }

        private class LectieItem
        {
            public int Id { get; set; }
            public string Titlu { get; set; }
            public bool Finalizata {  get; set; }
            public override string ToString()
            {
                return Titlu;
            }
        }

        private void IncarcareLectii()
        {
            listBoxLectii.Items.Clear();

            //citim progresul utilizatorului
            List<int> lectiiFinalizate = new List<int>();

            if (string.IsNullOrEmpty(username))
            {
                string queryProgres = "SELECT LectieId FROM ProgresLectii WHERE Username IS NULL";  //utilizatorul nu este logat
                SqlCommand cmdProgres = new SqlCommand(queryProgres, conn);

                conn.Open();
                SqlDataReader readerProgres = cmdProgres.ExecuteReader();
                while (readerProgres.Read())
                {
                    lectiiFinalizate.Add((int)readerProgres["LectieId"]);   //adaugam id-urile lectiilor finalizate
                }
                conn.Close();
            }
            else
            {
                //utilizatorul este logat
                string queryProgres = "SELECT LectieId FROM ProgresLectii WHERE Username = @username";
                SqlCommand cmdProgres = new SqlCommand(queryProgres, conn);
                cmdProgres.Parameters.AddWithValue("@username", username);
            
                conn.Open();
                SqlDataReader readerProgres = cmdProgres.ExecuteReader();
                while (readerProgres.Read()) { 
                    lectiiFinalizate.Add((int)readerProgres["LectieId"]);   //adaugam id-urile lectiilor finalizate
                }
                conn.Close();
            }
                

            //citim toate lectiile
            string queryLectii = "SELECT Id, Titlu FROM Lectii WHERE MaterieId = @materieId AND ClasaId = @clasaId";
            SqlCommand cmdLectii = new SqlCommand(queryLectii, conn);
            cmdLectii.Parameters.AddWithValue("@materieId", materieId);
            cmdLectii.Parameters.AddWithValue("@clasaId", clasaId);

            conn.Open();
            //citim toate lectiile finalizate
            SqlDataReader readerLectii = cmdLectii.ExecuteReader();
            while (readerLectii.Read()) //parcurgem lectiile
            {
                int lectieId = (int)readerLectii["Id"];
                string titlu = readerLectii["Titlu"].ToString();

                //verificam daca lectia este finalizata
                bool eFinalizata = lectiiFinalizate.Contains(lectieId);

                LectieItem lectieItem = new LectieItem
                {
                    Id = lectieId,
                    Titlu = titlu,
                    Finalizata = eFinalizata
                };

                if (eFinalizata)
                {
                    lectieItem.Titlu = "☑" + lectieItem.Titlu;    //asa am marcat lectia finalizata
                }

                listBoxLectii.Items.Add(lectieItem);    //adaugam lectia in listBox
            }
            conn.Close();
        }

        private void listBoxLectii_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxLectii_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxLectii.SelectedItem is LectieItem lectieSelectata)
            {
                //alegem lectia
                LectieForm lectie = new LectieForm(lectieSelectata.Id, username);
                lectie.Show();
            }
        }

        private void ListaLectiiForm_Load_1(object sender, EventArgs e)
        {
            //la incarcarea listei de lectii, salvam actiunea utilizatorului
            //daca ut. nu e logat, username = Necunoscut.
            AuditLogger logger = new AuditLogger();
            logger.LogAction(username ?? "Necunoscut", $"A accesat lista lectiilor pentru materia ID {materieId}, clasa ID {clasaId}.");

            IncarcareLectii();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            //luam form-ul parinte in care se afla form-ul ListaLectiiForm, si vedem daca e WelcomeForm
            //daca da, il salvam in parent
            WelcomeForm parent = this.ParentForm as WelcomeForm;

            if (parent != null)
            {
                parent.mainpanel.Controls.Clear();

                LectiiJocuri clasa = new LectiiJocuri(materieId, "", clasaId, parent.mainpanel, username);
                clasa.TopLevel = false;
                clasa.Dock = DockStyle.Fill;
                parent.mainpanel.Controls.Add(clasa);
                clasa.Show();
            }
        }
    }
}
