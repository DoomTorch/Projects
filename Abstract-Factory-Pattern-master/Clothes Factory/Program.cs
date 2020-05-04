using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clothes_Factory.Abstract_products;
using Clothes_Factory.Factories;

namespace Clothes_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Person1 = new Client(new ElegantClothesFactory());
            Person1.DescribeYourClothes();
            Console.WriteLine($"Person 1: {Person1.DescribeYourClothes()}\n");
            
            Client Person2 = new Client(new CasualClothesFactory());
            Console.WriteLine($"Person 2: {Person2.DescribeYourClothes()}\n");

            Client Person3 = new Client(new ElegantClothesFactory());
            Console.WriteLine($"Person 3: {Person3.DescribeYourClothes()}\n");

            Client Person4 = new Client(new CasualClothesFactory());
            Console.WriteLine($"Person 4: {Person4.DescribeYourClothes()}\n");

            Console.ReadLine();
           //string user = Convert.ToString(Console.ReadLine());

        }
    }
}
