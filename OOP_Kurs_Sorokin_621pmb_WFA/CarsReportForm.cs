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
    public partial class CarsReportForm : Form
    {
        public CarsReportForm()
        {
            InitializeComponent();
            dataGridView_CarsReport.AutoGenerateColumns = false;
            LoadDataIntoDataGridView();//Загрузка даних з json-файлу до колонок DataGridView
            dataGridView_CarsReport.Refresh();//обновить отображение DataGridView
        }

        //Метод для загрузки даних з json-файлу до колонок DataGridView
        public void LoadDataIntoDataGridView()
        {
            string filePath = @"Autopark.json"; // Файл должен находиться в директории с исполняемым файлом приложения
            List<Car> cars = Car.LoadCars(filePath); // метод LoadCars статичный и публичный
            dataGridView_CarsReport.DataSource = cars;
        }

        private void button_ToMain_Click(object sender, EventArgs e)
        {
            CarsParkForm carsParkForm = new CarsParkForm();
            this.Hide();
            carsParkForm.FormClosed += (s, args) => this.Close();
            carsParkForm.Show();
        }
    }
}
