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
    public partial class CarsParkForm : Form
    {
        private int currentSearchIndex = -1; // Переменная для хранения индекса текущей строки поиска

        private List<Car> cars;  // Добавление поля для хранения списка машин
        public CarsParkForm()
        {
            InitializeComponent();
            dataGridView_CarsPark.AutoGenerateColumns = false;
            LoadDataIntoDataGridView();//Загрузка даних з json-файлу до колонок DataGridView
           // SetColumnDisplayIndexes();//Встановлення порядку виведення колонок DataGridView
            dataGridView_CarsPark.Refresh();//обновить отображение DataGridView

            if (UserSession.IsGuest)//Якщо гість
            {
                button_Order.Enabled = false;// Зробити кнопку неактивною
            }

            // Показываем или скрываем кнопки в зависимости от пользователя
            if (UserSession.CurrentUser != null &&
                UserSession.CurrentUser.Username == "Admin" &&
                UserSession.CurrentUser.Password == "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5")
            {
                button_Add.Visible = true;
                button_Report.Visible = true;
                button_Issue.Visible = true;
            }
            else
            {
                button_Add.Visible = false;
                button_Report.Visible = false;
            }
        }

        //Метод для загрузки даних з json-файлу до колонок DataGridView
        public void LoadDataIntoDataGridView()
        {
            string filePath = @"Autopark.json"; // Файл должен находиться в директории с исполняемым файлом приложения
         List<Car> cars = Car.LoadCars(filePath); // метод LoadCars статичный и публичный
         //   cars = Car.LoadCars(filePath);
            dataGridView_CarsPark.DataSource = cars;
        }

        //Метод для встановлення порядку виведення колонок DataGridView
        private void SetColumnDisplayIndexes()
        {
            dataGridView_CarsPark.Columns["Column_manufacturer"].DisplayIndex = 0;
            dataGridView_CarsPark.Columns["Column_model"].DisplayIndex = 1;
            dataGridView_CarsPark.Columns["Column_year"].DisplayIndex = 2;
            dataGridView_CarsPark.Columns["Column_bodyType"].DisplayIndex = 3;
            dataGridView_CarsPark.Columns["Column_price"].DisplayIndex = 4;
            dataGridView_CarsPark.Columns["Column_isAvailable"].DisplayIndex = 5;
            dataGridView_CarsPark.Columns["Column_idCar"].DisplayIndex = 6;
        }

        private void button_Order_Click(object sender, EventArgs e)
        {
            OrderСarForm authForm = new OrderСarForm(cars);
            this.Hide();  // Скрыть текущую форму
            authForm.FormClosed += (s, args) => this.Close();  // Закрыть эту форму, когда закрывается форма авторизации
            authForm.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            this.Hide();
            addCarForm.FormClosed += (s, args) => this.Close();
            addCarForm.Show();

        }

        private void button_Report_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            this.Hide();
            reportForm.FormClosed += (s, args) => this.Close();
            reportForm.Show();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            UserSession.Logout();
            InitialForm initialForm = new InitialForm();
            this.Hide();
            initialForm.FormClosed += (s, args) => this.Close();
            initialForm.Show();
        }

        private void button_Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Reviews_Click(object sender, EventArgs e)
        {
            ReviewsForm reviewsForm = new ReviewsForm();
            this.Hide();//
            reviewsForm.FormClosed += (s, args) => this.Close();//
            reviewsForm.Show();
        }

        private void button_Conditions_Click(object sender, EventArgs e)
        {
            ConditionsForm conditionsForm = new ConditionsForm();
            this.Hide();
            conditionsForm.FormClosed += (s, args) => this.Close();
            conditionsForm.Show();
        }

        private void button_Contacts_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            this.Hide();
            contactsForm.FormClosed += (s, args) => this.Close();
            contactsForm.Show();
        }

        private void button_Issue_Click(object sender, EventArgs e)
        {
            IssueCarForm issueCarForm = new IssueCarForm();
            this.Hide();
            issueCarForm.FormClosed += (s, args) => this.Close();
            issueCarForm.Show();

        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            string searchValue = textBox_Find.Text.ToLower(); // Принимаем текст для поиска
            bool found = false;
            textBox_Find.Clear();

            // Начинаем поиск со следующей строки после текущего индекса
            int startIndex = currentSearchIndex + 1;
            for (int i = startIndex; i < dataGridView_CarsPark.Rows.Count; i++)
            {
                if (dataGridView_CarsPark.Rows[i].Cells["Column_Manufacturer"].Value.ToString().ToLower().Contains(searchValue))
                {
                    dataGridView_CarsPark.ClearSelection();
                    dataGridView_CarsPark.Rows[i].Selected = true;
                    dataGridView_CarsPark.FirstDisplayedScrollingRowIndex = i;
                    currentSearchIndex = i;
                    found = true;
                    break;
                }
            }

            // Если достигнут конец списка и совпадение не найдено, начать поиск сначала
            if (!found && startIndex > 0)
            {
                for (int i = 0; i < startIndex; i++)
                {
                    if (dataGridView_CarsPark.Rows[i].Cells["Column_Manufacturer"].Value.ToString().ToLower().Contains(searchValue))
                    {
                        dataGridView_CarsPark.ClearSelection();
                        dataGridView_CarsPark.Rows[i].Selected = true;
                        dataGridView_CarsPark.FirstDisplayedScrollingRowIndex = i;
                        currentSearchIndex = i;
                        found = true;
                        break;
                    }
                }
            }

            // Если поиск не дал результатов
            if (!found)
            {
                MessageBox.Show("Не знайдено жодного результату.");
                currentSearchIndex = -1; // Сброс индекса поиска
            }
        }
    }
}
