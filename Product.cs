using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    [Serializable]
    public abstract class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public Product(string name, string description, float price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}