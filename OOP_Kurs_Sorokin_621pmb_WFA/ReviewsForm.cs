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
    public partial class ReviewsForm : Form
    {
        string reviewsFilePath = @"Reviews.json";
        public ReviewsForm()
        {
            InitializeComponent();
            dataGridView_Reviews.AutoGenerateColumns = false;
            LoadReviews();//Загрузка даних з json-файлу до колонок DataGridView
            dataGridView_Reviews.Refresh();//обновить отображение DataGridView
        }
        private void LoadReviews()
        {
            var reviews = ReviewsDataAccess.LoadReviews(reviewsFilePath);
            dataGridView_Reviews.DataSource = reviews;
        }

        private void button_AddReview_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser != null)
            {
                var review = new Review
                {
                    Username = UserSession.CurrentUser.Username,
                    Content = textBox_NewReview.Text,
                    Date = DateTime.Now
                };
                ReviewsDataAccess.AddReviewToJson(reviewsFilePath, review);
                LoadReviews(); // Перезагрузка отзывов
                textBox_NewReview.Clear();
                MessageBox.Show("Отзыв добавлен!");
            }
            else
            {
                MessageBox.Show("Только зарегистрированные пользователи могут оставлять отзывы.");
            }

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
