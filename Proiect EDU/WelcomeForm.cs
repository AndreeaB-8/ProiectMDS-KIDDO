using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_EDU
{
    public partial class WelcomeForm : Form
    {
        public static WelcomeForm instance; //stocam o instanta pt acces global, pt a o putea accesa din alte parti
        public bool fromLogin { get; set; } = false;    /*vreau sa stiu daca este form-ul deschis prima data, sau dupa logare
                                    pt ca soricelul va spune altceva*/
        public static string username;  /*pt login, pt a se salva utilizatorul si activitatea lui in bd*/
        public WelcomeForm(bool fromLogin = false)
        {
            InitializeComponent();
            //pentru glitch-ul de fundal
            SetDoubleBuffered(mainpanel);
            SetDoubleBuffered(panelStart);

            this.fromLogin = fromLogin; //salveaza daca form-ul a fost deschis dupa logare sau nu
            instance = this;    //salvam in instance, pt a putea fi accesata din alte ferestre
        }

        private void SetDoubleBuffered(Control control) //GLITCH!!
        {   //face ca totul sa se miste mai lin
            typeof(Control).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, control, new object[] { true });
        }

        //cand vreau sa inlocuiesc ce e in ecran cu altceva (materii, cont)
        public void loadForm(object Form)   //curata fereastra si incarca un nou form
        {
            mainpanel.Controls.Clear();
            Form f = Form as Form;  //transformam obiectul Form in tipul Form
            f.TopLevel = false;     //nu e o fereastra principala, ci una care sta in interiorul altei ferestre
            f.Dock = DockStyle.Fill;    //form-ul se intinde complet cat mainpanel
            this.mainpanel.Controls.Add(f); //adauga fereastra in mainpanel
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowStartPanel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            panelStart.Visible = false;
            loadForm(new AccountForm(this));
        }

        //daca apasam Start, ne duce in form-ul cu clasele
        private void btnStart_Click(object sender, EventArgs e)
        {
            //trimitem this ca parametru(welcomeform), pt a putea comunica intre ele
            ClassForm classForm = new ClassForm(this, username);
            classForm.ClasaSelectata += ClassForm_ClasaSelectata;   //cand ut. alege o clasa, apelam fct. clasaSelectata
            loadForm(classForm);
        }

        private void ClassForm_ClasaSelectata(object sender, Tuple<int, string> e)
        {
            int clasaID = e.Item1;
            string clasaNume = e.Item2;

            //cand selectam o clasa vor aparea materiile
            SubjectsForm subjectsForm = new SubjectsForm(clasaID, clasaNume, mainpanel, username);
            loadForm(subjectsForm);
        }

        private void panelStart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxMouse_Click(object sender, EventArgs e)
        {

        }

        //VOCE SORICEL
        private void PlayMouseSound()
        {
            try
            {
                SoundPlayer player;
                if (fromLogin) 
                {
                    player = new SoundPlayer(Properties.Resources.VoceWelcomeBack);
                }
                else
                {
                    player = new SoundPlayer(Properties.Resources.VoceWelcomeForm);
                }
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare" + ex.Message);
            }
        }

        public void ShowStartPanel()
        {
            mainpanel.Controls.Clear();

            /*problema era ca se afisa mainpanel gol, de aceea punem conditia*/
            if (!mainpanel.Controls.Contains(panelStart))   // daca nu e deja adaugat
            {
                mainpanel.Controls.Add(panelStart);         // adaugam panelStart în mainpanel
            }
            panelStart.Visible = true;

            PlayMouseSound();   //vocea soricelului la prima accesare a aplicatiei
        }

        private void btnDespreNoi_Click(object sender, EventArgs e)
        {
            loadForm(new DespreNoiForm());
        }

        private void btnAdministrare_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();  // ma asigur ca am creat acest formular
            adminForm.ShowDialog();
        }

        public void SetAdminButtonVisibility(bool visibility)
        {
            btnAdministrare.Visible = visibility;
        }
    }
}
