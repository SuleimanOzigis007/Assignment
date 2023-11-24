using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.FruitProduct
{
    internal class fruitProduct
    { 
         public class Fruit
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Taste { get; set; }
        public bool IsEdible { get; set; }

        public Fruit(string name, string color, string taste, bool isEdible)
        {
            Name = name;
            Color = color;
            Taste = taste;
            IsEdible = isEdible;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Taste: {Taste}");
            Console.WriteLine($"Edible: {(IsEdible ? "Yes" : "No")}");
        }

        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }

        public void SetEdible(bool edibleStatus)
        {
            IsEdible = edibleStatus;
        }
    }

}

}
