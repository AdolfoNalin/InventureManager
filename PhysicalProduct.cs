using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    public class PhysicalProduct : Product,IStock
    {
        public float Freightage { get; set; }
        public int Stock {get; private set; }

        public PhysicalProduct(string name, string description, float price, float freightage) : base(name, description, price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Freightage = freightage;
        }

        public void GetInformationProduct()
        {
            Console.WriteLine($"Name: {this.Name}\nDescription: {this.Description}\nPrice: {this.Price}\nFreightage: {this.Freightage}\nStock: {this.Stock}");
        }

        public void AddInput()
        {
            throw new NotImplementedException();
        }

        public void AddOutput()
        {
            throw new NotImplementedException();
        }
    }
}