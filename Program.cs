using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assigment.FruitProduct.fruitProduct;

using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Fruit apple = new Fruit("Apple", "Red", "Sweet", true);
            Fruit orange = new Fruit("Orange", "Orange", "Tangy", true);
            Fruit banana = new Fruit("Banana", "Yellow", "Sweet", true);
            Fruit Strawberry = new Fruit("Strawberry", "Red", "Sweet", true);



            apple.DisplayInfo();
            orange.DisplayInfo();
            banana.DisplayInfo();


            apple.ChangeColor("Green");
            apple.SetEdible(false);


        }
    }
}



