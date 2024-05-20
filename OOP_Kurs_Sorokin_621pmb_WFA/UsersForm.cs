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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            dataGridView_Users.AutoGenerateColumns = false;
            LoadDataIntoDataGridView();//Загрузка даних з json-файлу до колонок DataGridView
                                       // SetColumnDisplayIndexes();//Встановлення порядку виведення колонок DataGridView
            dataGridView_Users.Refresh();//обновить отображение DataGridView
        }

        //Метод для загрузки даних з json-файлу до колонок DataGridView
        public void LoadDataIntoDataGridView()
        {
            string filePath = @"Users.json"; // Файл должен находиться в директории с исполняемым файлом приложения
            List<User> users = User.LoadUsers(filePath); // метод LoadCars статичный и публичный
                                                     //   cars = Car.LoadCars(filePath);
            dataGridView_Users.DataSource = users;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchText = textBox_Search.Text.ToLower(); // Получаем текст из TextBox и приводим его к нижнему регистру для регистронезависимого поиска
            dataGridView_Users.ClearSelection(); // Очищаем текущее выделение

            // Итерируем по всем строкам DataGridView
            for (int i = 0; i < dataGridView_Users.Rows.Count; i++)
            {
                // Проходим по каждому столбцу в строке
                foreach (DataGridViewCell cell in dataGridView_Users.Rows[i].Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        // Если значение ячейки содержит искомый текст, выделяем всю строку и перемещаем к ней прокрутку
                        dataGridView_Users.Rows[i].Selected = true;
                        dataGridView_Users.FirstDisplayedScrollingRowIndex = i;
                        return; // Заканчиваем поиск после первого совпадения
                    }
                }
            }
        }

        private void button_ToMain_Click(object sender, EventArgs e)
        {
            CarsParkForm carsParkForm = new CarsParkForm();
            this.Hide();
            carsParkForm.FormClosed += (s, args) => this.Close();
            carsParkForm.Show();
        }
    }
}
