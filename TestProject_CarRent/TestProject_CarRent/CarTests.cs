using OOP_Kurs_Sorokin_621pmb_WFA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace TestProject_CarRent
{
    [TestFixture]
    public class CarTests
    {
        private Car _car;

        [SetUp]
        public void Setup()
        {
            Car.filePath = "TestCar.json";

            _car = new Car(1, "Toyota", "Corolla", 2020, "Sedan", 20000, true, false);
            Car.filePath = "TestAutopark.json";
            // Подготовка тестового файла JSON, если нужно.
            File.WriteAllText(Car.filePath, "[]");  // Инициализация пустого списка автомобилей
        }

        [Test]
        public void LoadCars_WhenCalled_ReturnsCarList()
        {
            string jsonContent = "[{\"id_Car\": 1, \"manufacturer\": \"Toyota\", \"model\": \"Corolla\", \"year\": 2020, \"bodyType\": \"Sedan\", \"price\": 20000, \"isAvailable\": true, \"issued\": false}]";
            File.WriteAllText(Car.filePath, jsonContent);

            var cars = Car.LoadCars(Car.filePath);

            Assert.IsNotNull(cars);
            Assert.AreEqual(1, cars.Count);
            Assert.AreEqual("Toyota", cars[0].Manufacturer);
        }

        [Test]
        public void AddCarToJson_AddsCar()
        {
            // Передаем текущий объект _car в метод AddCarToJson
            Car.AddCarToJson(Car.filePath, _car);

            var cars = Car.LoadCars(Car.filePath);
            Assert.AreEqual(1, cars.Count);
            Assert.AreEqual(1, cars[0].id_Car);
        }

        [Test]
        public void Rent_ChangesIssuedStatusToTrue()
        {
            _car.Rent();
            Assert.IsTrue(_car.Issued);
        }

        [Test]
        public void Return_ChangesIssuedStatusToFalse()
        {
            _car.Issued = true; // Set the car as issued
            _car.Return();
            Assert.IsFalse(_car.Issued);
        }

        [Test]
        public void RemoveCar_RemovesCarFromList()
        {
            // Adding multiple cars for setup
            Car newCar = new Car(2, "Honda", "Civic", 2019, "Sedan", 18000, true, false);
            Car.AddCarToJson(Car.filePath, newCar); // Здесь также добавляем новый автомобиль
            Car.AddCarToJson(Car.filePath, _car);

            Car.RemoveCar(1);

            var cars = Car.LoadCars(Car.filePath);
            Assert.AreEqual(1, cars.Count);
            Assert.AreEqual(2, cars[0].id_Car);
        }

        [TearDown]
        public void Cleanup()
        {
            // Ensure each test is independent and cleanup after tests
            if (File.Exists(Car.filePath))
            {
                File.Delete(Car.filePath);
            }
        }
    }
}
