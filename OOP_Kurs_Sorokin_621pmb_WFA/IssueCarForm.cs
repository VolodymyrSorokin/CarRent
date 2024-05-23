using Newtonsoft.Json;
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
    public partial class IssueCarForm : Form
    {
        public IssueCarForm()
        {
            InitializeComponent();
            dataGridView_Issue.AutoGenerateColumns = false;
            LoadDataIntoDataGridView();//Загрузка даних з json-файлу до колонок DataGridView
                                       // SetColumnDisplayIndexes();//Встановлення порядку виведення колонок DataGridView
            dataGridView_Issue.Refresh();//обновить отображение DataGridView
        }

        //Метод для загрузки даних з json-файлу до колонок DataGridView
        //public void LoadDataIntoDataGridView()
        //{
         //   string filePath = @"Autopark.json"; // Файл должен находиться в директории с исполняемым файлом приложения
         //   List<Car> cars = Car.LoadCars(filePath); // Загружаем все автомобили
            //var bookedCars = cars.Where(car => car.Issued).ToList(); // Фильтруем только те, что забронированы (не доступны)
         //   dataGridView_Issue.DataSource = cars;
        //}

        public void LoadDataIntoDataGridView()
        {
            string filePath = @"BookingAuto.json"; // Файл должен находиться в директории с исполняемым файлом приложения
            List<Booking> bookings = Booking.LoadBookings(filePath); // метод LoadBooking статичный и публичный
            dataGridView_Issue.DataSource = bookings;
        }


        private void button_ToMain_Click(object sender, EventArgs e)
        {
            CarsParkForm carsParkForm = new CarsParkForm();
            this.Hide();
            carsParkForm.FormClosed += (s, args) => this.Close();
            carsParkForm.Show();

        }

        private void dataGridView_Issue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Извлекаем объект Car из строки, по которой кликнули
                var booking = (Booking)dataGridView_Issue.Rows[e.RowIndex].DataBoundItem;
                if (e.ColumnIndex == dataGridView_Issue.Columns["Column_Issue"].Index && !booking.Issued)
                {
                    booking.Rent();
                    MessageBox.Show("Автомобиль выдан", "Выдача", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (e.ColumnIndex == dataGridView_Issue.Columns["Column_Return"].Index && booking.Issued)
                {
                    booking.Return();
                    MessageBox.Show("Автомобиль возвращен", "Возврат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadDataIntoDataGridView(); // Перезагружаем данные, чтобы отразить изменения
            }
        }
    }
}
