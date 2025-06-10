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
    public partial class LectiiJocuri: Form
    {
        private Panel parentPanel;  //retinem panel ul unde se va afisa urm. formular
        private int materieId;
        private int clasaId;
        private string numeMaterie;
        private string username;

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");
        public LectiiJocuri(int id, string nume, int cId, Panel panel, string user)
        {
            InitializeComponent();
            //pentru glitch-ul de fundal
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            materieId = id;
            numeMaterie = nume;
            clasaId = cId;
            parentPanel = panel;
            username = user;
        }

        private void LectiiJocuri_Load(object sender, EventArgs e)
        {

        }

        private void btnLectii_Click(object sender, EventArgs e)
        {
            parentPanel.Controls.Clear();
            ListaLectiiForm lectie = new ListaLectiiForm(materieId, clasaId, parentPanel, username);
            lectie.TopLevel = false;
            lectie.Dock = DockStyle.Fill;
            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(lectie);
            lectie.Show();
        }

        private void btnJocuri_Click(object sender, EventArgs e)
        {
            parentPanel.Controls.Clear();
            ListaJocuriForm joc = new ListaJocuriForm(materieId, clasaId, parentPanel, username);
            joc.TopLevel = false;
            joc.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(joc);
            joc.Show();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            //luam form-ul parinte in care se afla form-ul LectiiJocuriForm, si vedem daca e WelcomeForm
            //daca da, il salvam in parent
            WelcomeForm parent = this.ParentForm as WelcomeForm;
            if (parent != null)
            {
                parent.mainpanel.Controls.Clear();

                SubjectsForm clasa = new SubjectsForm(clasaId, "", parent.mainpanel, username);
                clasa.TopLevel = false;
                clasa.Dock = DockStyle.Fill;
                parent.mainpanel.Controls.Add(clasa);
                clasa.Show();
            }
        }
    }
}
