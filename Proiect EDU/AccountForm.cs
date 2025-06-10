using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_EDU
{
    public partial class AccountForm : Form
    {
        //RegisterForm si LoginForm tb incarcate tot in mainPanel din WelcomeForm
        //deci transmitem referinta WelcomeForm catre AccountForm
        private WelcomeForm parentForm;

        public AccountForm(WelcomeForm form)
        {
            InitializeComponent();
            parentForm = form;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            /*RegisterForm tb incarcat tot in mainPanel din WelcomeForm*/
            parentForm.loadForm(new RegisterForm(parentForm));

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*LoginForm tb incarcat tot in mainPanel din WelcomeForm */
            parentForm.loadForm(new LoginForm(this, parentForm));
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            parentForm.ShowStartPanel();
        }
    }
}
