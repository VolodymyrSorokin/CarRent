using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public class Review
    {
        public int Id { get; set; }
        public string Username { get; set; } // Имя пользователя, оставившего отзыв
        public string Content { get; set; } // Текст отзыва
        public DateTime Date { get; set; } // Дата отзыва
    }
}
