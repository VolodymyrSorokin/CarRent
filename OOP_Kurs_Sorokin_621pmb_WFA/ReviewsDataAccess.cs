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
    public static class ReviewsDataAccess
    {
        public static List<Review> LoadReviews(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<Review>>(json) ?? new List<Review>();
                }
                return new List<Review>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить отзывы: " + ex.Message);
                return new List<Review>();
            }
        }

        public static void AddReviewToJson(string filePath, Review newReview)
        {
            var reviews = LoadReviews(filePath);
            newReview.Id = reviews.Any() ? reviews.Max(r => r.Id) + 1 : 1; // Присваивание ID
            reviews.Add(newReview);
            string updatedJson = JsonConvert.SerializeObject(reviews, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }
    }
}
