using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Car
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }

        public Car(string model, decimal price, string brand)
        {
            Model = model;
            Price = price;
            Brand = brand;
        }
    }
}
