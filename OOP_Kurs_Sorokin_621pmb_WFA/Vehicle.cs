using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace OOP_Kurs_Sorokin_621pmb_WFA
{
    public abstract class Vehicle
    {
        public int id_Car { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public bool IsAvailable { get; set; }

        protected Vehicle(int id_Car, string manufacturer, string model, int year, int price, bool isAvailable = true)
        {
            //Id_Car = id_Car;
            this.id_Car = id_Car;
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            Price = price;
            IsAvailable = isAvailable;
        }

        public abstract void DisplayInfo();
    }
}
