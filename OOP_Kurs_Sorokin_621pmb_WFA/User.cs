using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public class User
    {
        public int Id_User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //Метод для считывания данных из JSON-файла и конвертации их в список объектов Users
        public static List<User> LoadUsers(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                return users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить данные пользователей: " + ex.Message);
                return new List<User>();
            }
        }
    }
}
