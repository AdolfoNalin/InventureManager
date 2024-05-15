using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    public class PhysicalProduct : Product
    {
        public float Freightage { get; set; }
        public int Stock {get; set; }

        public PhysicalProduct(string name, string description, float price, float freightage) : base(name, description, price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Freightage = freightage;
        }
    }
}