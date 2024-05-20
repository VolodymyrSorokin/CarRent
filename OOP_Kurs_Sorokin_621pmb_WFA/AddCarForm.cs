using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string manufacturer = textBox_manufacturer.Text;
            string model = textBox_model.Text;
            int year = int.Parse(textBox_year.Text);
            string bodyType = textBox_bodyType.Text;
            int price = int.Parse(textBox_price.Text);
            string filePath = @"Autopark.json"; // Файл должен находиться в директории с исполняемым файлом приложения

            Car newCar = new Car
            {
                Manufacturer = manufacturer,
                Model = model,
                Year = year,
                BodyType = bodyType,
                Price = price
            };

            Car.AddCarToJson(filePath, newCar);

            MessageBox.Show("Додавання авломобіля пройшло успішно!");

            // Переход на форму авторизации
            CarsParkForm carsParkForm = new CarsParkForm();
            this.Hide();
            carsParkForm.FormClosed += (s, args) => this.Close();
            carsParkForm.Show();
        }
    }
}
