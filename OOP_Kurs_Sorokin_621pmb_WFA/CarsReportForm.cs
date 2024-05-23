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
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public partial class CarsReportForm : Form
    {
        private int currentSearchIndex = -1; // Переменная для хранения индекса текущей строки поиска

        public CarsReportForm()
        {
            InitializeComponent();
            dataGridView_CarsReport.AutoGenerateColumns = false;
            LoadDataIntoDataGridView();//Загрузка даних з json-файлу до колонок DataGridView
            dataGridView_CarsReport.Refresh();//обновить отображение DataGridView
            button_Save.Visible = false; // Скрываем кнопку сохранения при загрузке формы
            // Подписка на событие начала редактирования ячейки
            dataGridView_CarsReport.CellBeginEdit += DataGridView_CarsReport_CellBeginEdit;
        }

        //  Метод обработчика события начала редактирования ячейки Column_id_Car
        private void DataGridView_CarsReport_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Проверяем, что начато редактирование колонки с ID автомобиля
            if (dataGridView_CarsReport.Columns[e.ColumnIndex].Name == "Column_id_Car")
            {
                // Отменяем редактирование
                e.Cancel = true;
                // Выводим сообщение
                MessageBox.Show("Редагування ID автомобіля заборонено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Метод для загрузки даних з json-файлу до колонок DataGridView
        public void LoadDataIntoDataGridView()
        {
            string filePath = @"Autopark.json"; // Файл должен находиться в директории с исполняемым файлом приложения
            List<Car> cars = Car.LoadCars(filePath); // метод LoadCars статичный и публичный
            dataGridView_CarsReport.DataSource = cars;
        }

        private void button_ToMain_Click(object sender, EventArgs e)
        {
            CarsParkForm carsParkForm = new CarsParkForm();
            this.Hide();
            carsParkForm.FormClosed += (s, args) => this.Close();
            carsParkForm.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            this.Hide();
            addCarForm.FormClosed += (s, args) => this.Close();
            addCarForm.Show();
        }

        private void button_Delite_Click(object sender, EventArgs e)
        {
            if (dataGridView_CarsReport.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView_CarsReport.SelectedRows[0].Index;
                int carId = (int)dataGridView_CarsReport.Rows[selectedIndex].Cells["Column_id_Car"].Value;

                // Удаление автомобиля
                Car.RemoveCar(carId);
                // Удаление всех связанных бронирований
                Booking.RemoveAllBookingsForCar(carId);

                // Обновление данных на форме
                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рядок для видалення.");
            }

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            EnableEditing(true); // Делаем ячейки редактируемыми
        }

        private void EnableEditing(bool enable)
        {
            foreach (DataGridViewColumn column in dataGridView_CarsReport.Columns)
            {
                if (column.Name != "Column_id_Car")
                {
                    column.ReadOnly = !enable;
                }
            }
            button_Save.Visible = enable; // Показываем или скрываем кнопку сохранения
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveChanges(); // Сохраняем изменения
            EnableEditing(false); // Отключаем редактирование
            LoadDataIntoDataGridView(); // Обновляем данные в DataGridView
        }

        private void SaveChanges()
        {
            string filePath = @"Autopark.json";
            var cars = (List<Car>)dataGridView_CarsReport.DataSource;

            try
            {
                string updatedJson = JsonConvert.SerializeObject(cars, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
                MessageBox.Show("Зміни успішно збережено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося зберегти зміни: " + ex.Message);
            }
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            string searchValue = textBox_Find.Text.ToLower(); // Принимаем текст для поиска
            bool found = false;
            textBox_Find.Clear();

            // Начинаем поиск со следующей строки после текущего индекса
            int startIndex = currentSearchIndex + 1;
            for (int i = startIndex; i < dataGridView_CarsReport.Rows.Count; i++)
            {
                if (dataGridView_CarsReport.Rows[i].Cells["Column_Manufacturer"].Value.ToString().ToLower().Contains(searchValue))
                {
                    dataGridView_CarsReport.ClearSelection();
                    dataGridView_CarsReport.Rows[i].Selected = true;
                    dataGridView_CarsReport.FirstDisplayedScrollingRowIndex = i;
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
                    if (dataGridView_CarsReport.Rows[i].Cells["Column_Manufacturer"].Value.ToString().ToLower().Contains(searchValue))
                    {
                        dataGridView_CarsReport.ClearSelection();
                        dataGridView_CarsReport.Rows[i].Selected = true;
                        dataGridView_CarsReport.FirstDisplayedScrollingRowIndex = i;
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
