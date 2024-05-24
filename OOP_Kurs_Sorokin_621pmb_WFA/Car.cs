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
    public class Car : Vehicle, IRentable
    {
        // Создаём статическую переменную для управления путем к файлу
        public static string filePath = @"Autopark.json";

        public string BodyType { get; set; }
        //public int id_Car { get; set; }

        public Car() : base(0, "", "", 0, 0, true, false) { } // Пустой конструктор

        public Car(int id_Car, string manufacturer, string model, int year, string bodyType, int price, bool isAvailable = true, bool issued = false)
            : base(id_Car, manufacturer, model, year, price, isAvailable, issued)
        {
            BodyType = bodyType;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car: {Manufacturer}, {Model}, {Year}, {BodyType}, {Price}, Available: {IsAvailable}");
        }

        //Метод для считывания данных из JSON-файла и конвертации их в список объектов Car
        public static List<Car> LoadCars(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
                return cars;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Не удалось загрузить данные автомобилей: " + ex.Message);
                return new List<Car>();
            }
        }

        //Метод для додавання нового автомобіля до JSON-файлу
        public static void AddCarToJson(string filePath, Car newCar)
        {
            try
            {
                var cars = LoadCars(filePath);
                // Назначаем новому автомобілю ID, который на 1 больше максимального текущего ID
                newCar.id_Car = cars.Any() ? cars.Max(c => c.id_Car) + 1 : 1;
                cars.Add(newCar);
                string updatedJson = JsonConvert.SerializeObject(cars, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Не вдалося записати дані автомобіля: " + ex.Message);
            }
        }


        public void Rent()
        {
            // Проверяем, что автомобиль не выдан
            if (!Issued)
            {
                Issued = true;
                SaveChanges();
                // Console.WriteLine($"{Manufacturer} {Model} is now rented.");
            }
        }

        public void Return()
        {
            // Меняем статус на 'не выдан'
            Issued = false;
            IsAvailable = true; // Обновляем доступность автомобиля
            SaveChanges();
            // Console.WriteLine($"{Manufacturer} {Model} has been returned.");
        }

        // Метод для сохранения изменений в JSON
        private void SaveChanges()
        {
            //var filePath = "Autopark.json"; // Указываете путь к вашему JSON файлу с автомобилями
            var cars = LoadCars(filePath);
            var car = cars.FirstOrDefault(c => c.id_Car == this.id_Car);
            if (car != null)
            {
                car.Issued = this.Issued;
                string updatedJson = JsonConvert.SerializeObject(cars, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
          
        }

        public static void RemoveCar(int carId)
        {
            //string filePath = @"Autopark.json";
            List<Car> cars = LoadCars(filePath);
            cars = cars.Where(car => car.id_Car != carId).ToList();
            File.WriteAllText(filePath, JsonConvert.SerializeObject(cars, Formatting.Indented));
        }


    }
}
