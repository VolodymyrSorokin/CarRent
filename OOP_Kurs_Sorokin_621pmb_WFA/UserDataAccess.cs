using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public class UserDataAccess
    {
        //Метод для читання даних із JSON-файлу
        public static List<User> LoadUsersFromJson(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося завантажити дані користувачів: " + ex.Message);
                return new List<User>();
            }
        }

        //Метод для додавання нового користувача до JSON-файлу
        public static void AddUserToJson(string filePath, User newUser)
        {
            try
            {
                var users = LoadUsersFromJson(filePath);

                // Хешируем пароль перед сохранением
                newUser.Password = SecurityHelper.HashPassword(newUser.Password);

                // Назначаем новому пользователю ID, который на 1 больше максимального текущего ID
                newUser.Id_User = users.Any() ? users.Max(u => u.Id_User) + 1 : 1;
                users.Add(newUser);
                string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося записати дані користувача: " + ex.Message);
            }
        }
    }
}
