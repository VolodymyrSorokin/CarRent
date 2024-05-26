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
    public partial class OrderСarForm : Form
    {
        //private List<Car> cars;
        public OrderСarForm(List<Car> cars)
        {
            InitializeComponent();
            dataGridView_Order.AutoGenerateColumns = false;
            // подписка на события. Обработчики событий будут активироваться при изменении значения в DateTimePicker
            dateTimePicker_BookingStartDate.ValueChanged += DateTimePicker_BookingStartDate_ValueChanged;
            dateTimePicker_BookingEndDate.ValueChanged += DateTimePicker_BookingEndDate_ValueChanged;

            // this.cars = cars;
        }

        private void button_AvailableCars_Click(object sender, EventArgs e)
        {
            string filePath = @"BookingAuto.json"; // Файл повинен знаходитися в тій самій текі, де і виконується програма
            List<Booking> bookings = Booking.LoadBookings(filePath);
            List<Car> cars = Car.LoadCars(@"Autopark.json");
            DateTime startDate = dateTimePicker_BookingStartDate.Value;
            DateTime endDate = dateTimePicker_BookingEndDate.Value;

/*            string message = $"startDate: {startDate}, endDate: {endDate}\n\n";
            foreach (var booking in bookings)
            {
                message += $"Booking for car {booking.id_Car}: start date - {booking.booking_start_date}, end date - {booking.booking_end_date}\n";
            }

            message += "\nIsAvailable для кожного автомобіля:\n";
            foreach (Car car in cars)
            {
                car.IsAvailable = !bookings.Any(b => b.id_Car == car.id_Car &&
                                                    b.booking_end_date >= startDate &&
                                                    b.booking_start_date <= endDate);
                message += $"Car {car.id_Car}: IsAvailable - {car.IsAvailable}\n";
            }

            bool datesOverlap = bookings.Any(b => b.booking_end_date >= startDate && b.booking_start_date <= endDate);
            string overlapMessage = datesOverlap ? "Обрані дати перетинаються з існуючими бронюваннями." : "Обрані дати не перетинаються з жодними бронюваннями.";

            MessageBox.Show(message + "\n" + overlapMessage, "Дані про бронювання та дати", MessageBoxButtons.OK, MessageBoxIcon.Information);
*/
            // Фільтрація списку автомобілів, щоб відобразити лише доступні (не заброньовані)
            List<Car> availableCars = cars.Where(car => car.IsAvailable).ToList();

            dataGridView_Order.DataSource = null;
            dataGridView_Order.DataSource = availableCars; // Тепер прив'язуємо тільки доступні автомобілі
        }

        private void dataGridView_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Order.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int idCar = Convert.ToInt32(dataGridView_Order.Rows[e.RowIndex].Cells["Column_idCar"].Value);
                int idUser = UserSession.CurrentUser.Id_User; // Получаем Id текущего пользователя
                DateTime startDate = dateTimePicker_BookingStartDate.Value;
                DateTime endDate = dateTimePicker_BookingEndDate.Value;

                Booking newBooking = new Booking
                {
                    id_Car = idCar,
                    id_User = idUser,
                    booking_start_date = startDate,
                    booking_end_date = endDate
                };

                Booking.AddBookingToJson(@"BookingAuto.json", newBooking);

                // Отключаем кнопку и меняем текст (если нужно)
               // buttonCell.Enabled = false;
                //buttonCell.Value = "Заказ оформлен";
                //dataGridView_Order.InvalidateCell(buttonCell);

                // Показываем MessageBox
                MessageBox.Show("Ваш заказ успешно оформлен!");
            }
        }

        private void button_ToMain_Click(object sender, EventArgs e)
        {
            CarsParkForm carsParkForm = new CarsParkForm();
            this.Hide();
            carsParkForm.FormClosed += (s, args) => this.Close();
            carsParkForm.Show();
        }

        //Обработчик событий изменения значения DateTimePicker_BookingStartDate
        private void DateTimePicker_BookingStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_BookingStartDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Неможливо забронювати авто на дату, що вже минула. Будь ласка, виберіть іншу дату.", "Невірна дата", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker_BookingStartDate.Value = DateTime.Now; // Устанавливаем сегодняшнюю дату
            }
        }

        //Обработчик событий изменения значения DateTimePicker_BookingEndDate
        private void DateTimePicker_BookingEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_BookingEndDate.Value.Date <= dateTimePicker_BookingStartDate.Value.Date)
            {
                MessageBox.Show("Дата завершення бронювання повинна бути пізніше дати початку бронювання. Будь ласка, виберіть іншу дату.", "Невірна дата", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker_BookingEndDate.Value = dateTimePicker_BookingStartDate.Value.AddDays(1); // Устанавливаем дату на один день после начала бронирования
            }
        }
    }
}
