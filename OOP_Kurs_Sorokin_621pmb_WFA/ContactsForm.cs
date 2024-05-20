using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()
        {
            InitializeComponent();
            LoadContacts();
        }

        private void LoadContacts()
        {
            // Загрузите текст условий аренды
            textBox_Contacts.Text = File.ReadAllText(@"Contacts.txt");
            textBox_Contacts.Select(0, 0); // Снимает выделение, устанавливая курсор в начало текста
            // Настройка доступности кнопки редактирования
            button_Edit.Visible = UserSession.CurrentUser != null && UserSession.CurrentUser.Username == "Admin" &&
                UserSession.CurrentUser.Password == "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5";
        }

        private void button_ToMain_Click(object sender, EventArgs e)
        {
            CarsParkForm carsParkForm = new CarsParkForm();
            this.Hide();
            carsParkForm.FormClosed += (s, args) => this.Close();
            carsParkForm.Show();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            textBox_Contacts.ReadOnly = false;
            button_Save.Visible = true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"Contacts.txt", textBox_Contacts.Text);
            textBox_Contacts.ReadOnly = true;
            MessageBox.Show("Контакти оновлено.");
        }
    }
}
