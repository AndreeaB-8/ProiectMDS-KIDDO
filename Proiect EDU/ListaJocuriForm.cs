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
    public partial class ListaJocuriForm: Form
    {
        private Panel parentPanel;  //retinem panel ul unde se va afisa urm. formular
        private int materieId;
        private int clasaId;
        private string username;

        private SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");

        public ListaJocuriForm(int mId, int cId, Panel panel, string user)
        {
            InitializeComponent();
            //pentru glitch-ul de fundal
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            //lectieId = lId;
            materieId = mId;
            clasaId = cId;
            parentPanel = panel;
            username = user;
        }

        private class JocItem   //fiecare joc din lista va prezenta aceste atribute
        {
            public int Id { get; set; }
            public string Nume { get; set; }
            public string Tip {  get; set; }
            public bool Finalizat {  get; set; }
            public int Scor {  get; set; }
            public override string ToString()   //returneaza doar Nume
            {
                return Nume;
            }
        }

        private void IncarcareJocuri()
        {
            listBoxJocuri.Items.Clear();

            //citim progresul utilizatorului
            List<(int JocId, int Scor)> jocuriFinalizate = new List<(int, int)>();


            if (string.IsNullOrEmpty(username))
            {
                string queryProgres = "SELECT JocId, Scor FROM ProgresJocuri WHERE Username IS NULL";   //utilizatorul nu este logat
                SqlCommand cmdProgres = new SqlCommand(queryProgres, conn);

                conn.Open();
                SqlDataReader readerProgres = cmdProgres.ExecuteReader();
                while (readerProgres.Read())
                {
                    int jocId = (int)readerProgres["JocId"];
                    int scor = (int)readerProgres["Scor"];
                    jocuriFinalizate.Add((jocId, scor));   //adaugam id-urile jocurilor finalizate
                }
                conn.Close();
            }
            else
            {
                //utilizatorul este logat
                string queryProgres = "SELECT JocId, Scor FROM ProgresJocuri WHERE Username = @username";
                SqlCommand cmdProgres = new SqlCommand(queryProgres, conn);
                cmdProgres.Parameters.AddWithValue("@username", username);

                conn.Open();
                SqlDataReader readerProgres = cmdProgres.ExecuteReader();
                while (readerProgres.Read())
                {
                    int jocId = (int)readerProgres["JocId"];
                    int scor = (int)readerProgres["Scor"];
                    jocuriFinalizate.Add((jocId, scor));   //adaugam id-urile si scorul jocurilor finalizate
                }
                conn.Close();
            }

            //citim toate jocurile
            string query = "SELECT Id, Nume, Tip FROM Jocuri WHERE MaterieId = @materieId AND ClasaId = @clasaId";
            SqlCommand cmdJocuri = new SqlCommand(query, conn);
            cmdJocuri.Parameters.AddWithValue("@materieId", materieId);
            cmdJocuri.Parameters.AddWithValue("@clasaId", clasaId);
            
            conn.Open();
            //citim toate jocurile finalizate
            SqlDataReader readerJocuri = cmdJocuri.ExecuteReader();
            while (readerJocuri.Read()) {   //parcurgem toate jocurile
                int jocId = (int)readerJocuri["Id"];
                string nume = readerJocuri["Nume"].ToString();
                string tip = readerJocuri["Tip"].ToString();

                /*cautam in jocuriFinalizate*/
                /*jocFinalizat = progresul (jocId + scor) al jocului curent, asta daca el exista in lista*/
                //jocFinalizat stocheaza (jocId, scor) sau NULL
                (int JocId, int Scor)? jocFinalizat = null;

                foreach(var progres in jocuriFinalizate)    //parcurgem lista de jocuri finalizate
                {
                    if(progres.JocId == jocId)  //daca jocul este jocul pe care il verificam (jocId)
                    {
                        jocFinalizat = progres; //salvam progresul in jocFinalizat
                        break;
                    }
                }

                /*daca am gasit un joc (jocFinalizat != null)*/
                bool eFinalizat = jocFinalizat != null;
                
                int scor;
                if (eFinalizat)
                {
                    scor = jocFinalizat.Value.Scor; /*folosim scorul lui, sau 0 daca nu e finalizat*/
                }
                else
                {
                    scor = 0;
                }

                JocItem jocItem = new JocItem   //un nou obiect de tipul jocItem
                {
                    Id = jocId,
                    Nume = nume,
                    Tip = tip,
                    Finalizat = eFinalizat,
                    Scor = scor
                };
                if (eFinalizat)
                {
                    jocItem.Nume = "☑" + jocItem.Nume + $" (Scor: {scor})";
                }
                listBoxJocuri.Items.Add(jocItem);
            }
            conn.Close();
        }

        private void ListaJocuriForm_Load(object sender, EventArgs e)
        {
            //la incarcarea listei de jocuri, salvam actiunea utilizatorului
            //daca ut. nu e logat, username = Necunoscut.
            AuditLogger logger = new AuditLogger();
            logger.LogAction(username ?? "Necunoscut", $"A accesat lista jocurilor pentru materia ID {materieId}, clasa ID {clasaId}.");

            IncarcareJocuri();
        }

        private void listBoxJocuri_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxJocuri.SelectedItem is JocItem jocSelectat){
                //alegem jocul in functie de tip: quiz, completare, etc.
                switch(jocSelectat.Tip.ToLower())
                {
                    case "quiz":
                        QuizForm quiz = new QuizForm(jocSelectat.Id, username);
                        quiz.Show();
                        break;

                    case "completare vecini":
                        Vecini vecini = new Vecini(jocSelectat.Id, username);
                        vecini.Show(); 
                        break;

                    default:
                        MessageBox.Show("Tipul jocului nu exista! Incearca din nou!");
                        break;
                }
            }
        }

        private void listBoxJocuri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            //luam form-ul parinte in care se afla form-ul ListaJocuriForm, si vedem daca e WelcomeForm
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
