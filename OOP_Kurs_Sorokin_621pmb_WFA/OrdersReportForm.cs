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
    public partial class OrdersReportForm : Form
    {
        private int currentSearchIndex = -1;// переменная для хранить индекса текущей строки для поиска

        public OrdersReportForm()
        {
            InitializeComponent();
            dataGridView_OrdersReport.AutoGenerateColumns = false;
            LoadDataIntoDataGridView();//Загрузка даних з json-файлу до колонок DataGridView
                                       // SetColumnDisplayIndexes();//Встановлення порядку виведення колонок DataGridView
            dataGridView_OrdersReport.Refresh();//обновить отображение DataGridView
        }

        //Метод для загрузки даних з json-файлу до колонок DataGridView
        public void LoadDataIntoDataGridView()
        {
            string filePath = @"BookingAuto.json"; // Файл должен находиться в директории с исполняемым файлом приложения
            List<Booking> bookings = Booking.LoadBookings(filePath); // метод LoadBooking статичный и публичный
            dataGridView_OrdersReport.DataSource = bookings;
        }

        private void button_ToMain_Click(object sender, EventArgs e)
        {
            CarsParkForm carsParkForm = new CarsParkForm();
            this.Hide();
            carsParkForm.FormClosed += (s, args) => this.Close();
            carsParkForm.Show();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            DateTime searchDate = dateTimePicker_Date.Value.Date; // Получаем дату из dateTimePicker
            bool found = false;

            // Начинаем поиск со следующей строки после текущего индекса
            int startIndex = currentSearchIndex + 1;
            for (int i = startIndex; i < dataGridView_OrdersReport.Rows.Count; i++)
            {
                DateTime rowDate = Convert.ToDateTime(dataGridView_OrdersReport.Rows[i].Cells["Column_booking_start_date"].Value).Date;
                if (rowDate == searchDate)
                {
                    dataGridView_OrdersReport.ClearSelection();
                    dataGridView_OrdersReport.Rows[i].Selected = true;
                    dataGridView_OrdersReport.FirstDisplayedScrollingRowIndex = i;
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
                    DateTime rowDate = Convert.ToDateTime(dataGridView_OrdersReport.Rows[i].Cells["Column_booking_start_date"].Value).Date;
                    if (rowDate == searchDate)
                    {
                        dataGridView_OrdersReport.ClearSelection();
                        dataGridView_OrdersReport.Rows[i].Selected = true;
                        dataGridView_OrdersReport.FirstDisplayedScrollingRowIndex = i;
                        currentSearchIndex = i;
                        found = true;
                        break;
                    }
                }
            }

            // Если поиск не дал результатов
            if (!found)
            {
                MessageBox.Show("Нет заказов на указанную дату.");
                currentSearchIndex = -1; // Сброс индекса поиска
            }
        }
    }
}
