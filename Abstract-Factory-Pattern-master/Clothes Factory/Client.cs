using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clothes_Factory.Abstract_products;

namespace Clothes_Factory
{
    class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trousers;
        private readonly Eyewear _eyewear;

        public Client(ClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousers();
            _eyewear = factory.CreateEyewear();
        }

        public string DescribeYourClothes()
        {

            return $"Today I'm dressed in: {_shirt.GetType().Name} and {_trousers.GetType().Name} with a pair of {_eyewear.GetType().Name}";
        }
    }
}
