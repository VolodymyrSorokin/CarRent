using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            string firstName = textBox_Name.Text;
            string lastName = textBox_SurName.Text;
            string phone = textBox_Phone.Text;
            string username = textBox_Login.Text;
            string password = textBox_Parol.Text;
            string filePath = @"Users.json"; // Файл должен находиться в директории с исполняемым файлом приложения

            // Регулярное выражение для проверки на латинские буквы и цифры
            Regex validCharsRegex = new Regex(@"^[a-zA-Z0-9]+$");

            // Проверка на минимальную длину логина и соответствие символов
            if (username.Length < 5 || !validCharsRegex.IsMatch(username))
            {
                MessageBox.Show("Логін повинен складатися з мінімум 5 латинських букв або цифр.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Login.Focus();
                return;
            }
            // Проверка на минимальную длину пароля и соответствие символов
            if (password.Length < 5 || !validCharsRegex.IsMatch(password))
            {
                MessageBox.Show("Пароль повинен складатися з мінімум 5 латинських букв або цифр.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Parol.Focus();
                return;
            }

            List<User> users = UserDataAccess.LoadUsersFromJson(filePath);
            if (users.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                textBox_Login.Text = "";
                textBox_Parol.Text = "";
                textBox_Login.Focus();
                MessageBox.Show("Введений логін існує. Введіть інший логін.");
                return;
            }

            User newUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Username = username,
                Password = password
            };

            UserDataAccess.AddUserToJson(filePath, newUser);

            MessageBox.Show("Реєстрація пройшла успішно!");

            // Переход на форму авторизации
            this.Hide();
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.FormClosed += (s, args) => this.Close();
            authForm.Show();
        }
    }
}
