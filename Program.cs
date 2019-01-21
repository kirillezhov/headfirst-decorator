using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage2 = new Whip(new Mocha(new Mocha(new DarkRoast())));
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            Beverage beverage3 = new Whip(new Mocha(new Soy(new HouseBlend())));
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());

            Console.ReadKey();
        }
    }
}
