using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public class Booking
    {
        public int id_Car { get; set; }
        public int id_User { get; set; }
        public DateTime booking_start_date { get; set; }
        public DateTime booking_end_date { get; set; }
    

        //Метод для считывания данных из JSON-файла и конвертации их в список объектов Booking
        public static List<Booking> LoadBookings(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                List<Booking> bookings = JsonConvert.DeserializeObject<List<Booking>>(json);
                return bookings;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить данные о бронированиях: " + ex.Message);
                return new List<Booking>();
            }
        }

        //Метод для додавання нового користувача до JSON-файлу
        public static void AddBookingToJson(string filePath, Booking newBooking)
        {
            try
            {
                var bookings = LoadBookings(filePath);
                bookings.Add(newBooking);
                string updatedJson = JsonConvert.SerializeObject(bookings, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении бронирований: " + ex.Message);
            }
        }

    }

}
