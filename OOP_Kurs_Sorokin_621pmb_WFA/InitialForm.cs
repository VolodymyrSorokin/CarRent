using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorizationForm authForm = new AuthorizationForm();
            this.Hide();  // Скрыть текущую форму
            authForm.FormClosed += (s, args) => this.Close();  // Закрыть эту форму, когда закрывается форма авторизации
            authForm.Show();
        }

        private void button_Registration_Click(object sender, EventArgs e)
        {
            RegistrationForm authForm = new RegistrationForm();
            this.Hide();  // Скрыть текущую форму
            authForm.FormClosed += (s, args) => this.Close();  // Закрыть эту форму, когда закрывается форма авторизации
            authForm.Show();

        }

        private void button_Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Guest_Click(object sender, EventArgs e)
        {
            UserSession.LoginAsGuest();
            CarsParkForm carsParkForm = new CarsParkForm();
            this.Hide();
            carsParkForm.FormClosed += (s, args) => this.Close();
            carsParkForm.Show();
        }
    }
}
