using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace zd7
{
    public class Cake
    {
        public string image;
        public string name;
        public double price;
        public string category; 

        public string ed;

        public string vitamins; 

        public string postav;

        public int quantity;

        public string recept;
        public double fats;
        public double carbohydrates;
        public double protein;


        public Cake(string image, string name, string category, string ed, string vitamins, string postav, string recept, double fats, double carbohydrates, double protein, double price, int quantity) { 
        
            this.image = image;
            this.name = name;
            this.price = price;
            this.category = category;
            this.ed = ed;
            this.vitamins = vitamins;
            this.postav = postav;
            this.quantity = quantity;
            this.recept = recept;
            this.fats = fats;
            this.carbohydrates = carbohydrates;
            this.protein = protein;
        }
    }
}
