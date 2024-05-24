using Newtonsoft.Json;
using System.IO;


using OOP_Kurs_Sorokin_621pmb_WFA;

namespace TestProject_CarRent
{
    [TestFixture]
    public class BookingTests
    {
        private Booking _booking;  // Объявите _booking как поле класса

        [SetUp]
        public void Setup()
        {
            Booking.filePath = "TestBookingAuto.json";
           // Booking.filePath = "D:\\Vlad\\ВступУкр\\МлБак\\4_Семестр\\ООП_Курсовой\\Реализация\\OOP_Kurs_Sorokin_621pmb_WFA\\TestProject_CarRent\\TestProject_CarRent\\TestBookingAuto.json";
        
        _booking = new Booking
            {
                id_Car = 1,
                id_User = 1,
                booking_start_date = DateTime.Today,
                booking_end_date = DateTime.Today.AddDays(1),
                Issued = false
            };

            // Поместите вызов Console.WriteLine здесь, чтобы он выводился при каждом запуске теста
            Console.WriteLine("Testing with file path: " + Path.GetFullPath(Booking.filePath));
        }

        [Test]
        public void Rent_WhenCalled_ChangesIssuedToTrue()
        {
            // Act
            _booking.Rent();

            // Assert
            Assert.IsTrue(_booking.Issued);
        }

        [Test]
        public void Return_WhenCalled_ChangesIssuedToFalse()
        {
            // Arrange
            _booking.Issued = true;

            // Act
            _booking.Return();

            // Assert
            Assert.IsFalse(_booking.Issued);
        }

        [Test]
        public void Rent_WhenAlreadyIssued_DoesNotChangeIssued()
        {
            // Arrange
            _booking.Issued = true;

            // Act
            _booking.Rent();

            // Assert
            Assert.IsTrue(_booking.Issued); // Состояние не должно измениться
        }

        [Test]
        public void Return_WhenNotIssued_DoesNotChangeIssued()
        {
            // Act
            _booking.Return();

            // Assert
            Assert.IsFalse(_booking.Issued); // Состояние не должно измениться
        }

        [Test]
        public void LoadBookings_WhenCalled_ReturnsListOfBookings()
        {
            // Arrange
            string testFilePath = "TestBookingAuto.json";
            File.WriteAllText(testFilePath, "[{\"id_Car\": 1, \"id_User\": 1, \"booking_start_date\": \"2021-01-01T00:00:00\", \"booking_end_date\": \"2021-01-02T00:00:00\", \"Issued\": false}]");

            Booking.filePath = testFilePath;

            // Act
            var bookings = Booking.LoadBookings(Booking.filePath);

            // Assert
            Assert.IsNotNull(bookings);
            Assert.IsNotEmpty(bookings);
            Assert.AreEqual(1, bookings[0].id_Car);

            // Clean up
            File.Delete(testFilePath);
        }

        [Test]
        public void SaveChanges_UpdatesExistingBooking()
        {
            // Arrange
            var testFilePath = "TestBookingAuto.json";
            var initialJson = "[{\"id_Car\": 1, \"id_User\": 1, \"Issued\": false}]";
            File.WriteAllText(testFilePath, initialJson);
            Booking.filePath = testFilePath;
            var booking = new Booking { id_Car = 1, id_User = 1, Issued = true };

            // Act
            Booking.SaveChanges(booking);
            var bookings = Booking.LoadBookings(testFilePath);

            // Assert
            Assert.IsTrue(bookings[0].Issued);

            // Clean up
            File.Delete(testFilePath);
        }

        [Test]
        public void AddBookingToJson_AddsNewBooking()
        {
            // Arrange
            var testFilePath = "TestBookingAuto.json";
            File.WriteAllText(testFilePath, "[]"); // Empty JSON array
            Booking.filePath = testFilePath;
            var newBooking = new Booking { id_Car = 2, id_User = 2, Issued = false };

            // Act
            Booking.AddBookingToJson(testFilePath, newBooking);
            var bookings = Booking.LoadBookings(testFilePath);

            // Assert
            Assert.AreEqual(1, bookings.Count);
            Assert.AreEqual(2, bookings[0].id_Car);

            // Clean up
            File.Delete(testFilePath);
        }

        [Test]
        public void RemoveAllBookingsForCar_RemovesCorrectBooking()
        {
            // Arrange
            var testFilePath = "TestBookingAuto.json";
            var initialJson = "[{\"id_Car\": 1, \"id_User\": 1}, {\"id_Car\": 2, \"id_User\": 2}]";
            File.WriteAllText(testFilePath, initialJson);
            Booking.filePath = testFilePath;

            // Act
            Booking.RemoveAllBookingsForCar(1);
            var bookings = Booking.LoadBookings(testFilePath);

            // Assert
            Assert.AreEqual(1, bookings.Count);
            Assert.AreEqual(2, bookings[0].id_Car);

            // Clean up
            File.Delete(testFilePath);
        }



    }


}