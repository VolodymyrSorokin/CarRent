using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;
using OOP_Kurs_Sorokin_621pmb_WFA;

namespace TestProject_CarRent
{
    [TestFixture]
    public class UserTest
    {
        private string _filePath = "TestUsers.json";

        [SetUp]
        public void Setup()
        {
            // Создаем тестовый файл с пользователями
            string jsonContent = "[{\"Id_User\":1, \"FirstName\":\"John\", \"LastName\":\"Doe\", \"Phone\":\"1234567890\", \"Username\":\"johndoe\", \"Password\":\"password123\"}]";
            File.WriteAllText(_filePath, jsonContent);
        }

        [Test]
        public void LoadUsers_WhenCalled_ReturnsListOfUsers()
        {
            // Act
            var users = User.LoadUsers(_filePath);

            // Assert
            Assert.IsNotNull(users);
            Assert.AreEqual(1, users.Count);
            Assert.AreEqual("John", users[0].FirstName);
            Assert.AreEqual("Doe", users[0].LastName);
            Assert.AreEqual("1234567890", users[0].Phone);
            Assert.AreEqual("johndoe", users[0].Username);
            Assert.AreEqual("password123", users[0].Password);
        }

        [Test]
        public void LoadUsers_WhenFileNotFound_ReturnsEmptyList()
        {
            // Arrange
            File.Delete(_filePath); // Удаление файла, чтобы вызвать ошибку

            // Act
            var users = User.LoadUsers(_filePath);

            // Assert
            Assert.IsNotNull(users);
            Assert.IsEmpty(users);
        }

        [TearDown]
        public void CleanUp()
        {
            // Удаляем тестовый файл после каждого теста
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
        }
    }
}
