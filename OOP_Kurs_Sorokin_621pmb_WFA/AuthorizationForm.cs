using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            string username = textBox_Login.Text;
            string password = textBox_Parol.Text;
            //string filePath = "D:\\Vlad\\ВступУкр\\МлБак\\4_Семестр\\ООП_Курсовой\\Users.json";
            string filePath = @"Users.json"; // Файл должен находиться в директории с исполняемым файлом приложения


            List<User> users = UserDataAccess.LoadUsersFromJson(filePath);
            string hashedPassword = SecurityHelper.HashPassword(password); // Хешируем пароль для сравнения

            User authenticatedUser = users.FirstOrDefault(u => u.Username == username && u.Password == hashedPassword);

            if (authenticatedUser != null)
            {
                UserSession.Login(authenticatedUser); // Сохраняем пользователя в сессии
                CarsParkForm carsParkForm = new CarsParkForm();
                this.Hide();
                carsParkForm.FormClosed += (s, args) => this.Close();
                carsParkForm.Show();

            }
            else
            {
                MessageBox.Show("Неправильний логін або пароль", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.FormClosed += (s, args) => this.Close();
            initialForm.Show();

        }
    }
}
