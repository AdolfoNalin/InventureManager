using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    [Serializable]
    public class Ebook : Product, IStock
    {
        public string Author { get; set; }
        public float Memory { get; set; }
        public int Sales { get; private set; }

        public Ebook(string name, string description, string author, float price, float memory) : base(name, description, price)
        {
            this.Name = name;
            this.Description = description;
            this.Author = author;
            this.Price = price;
            this.Memory = memory;
        }

        public void GetInformationProduct()
        {
            Console.WriteLine($"Name: {this.Name}\nDescription: {this.Description}\nPrice: {this.Price}\nFreightage: {this.Author}\nStock: {this.Memory}\nSales {this.Sales}");
            Console.WriteLine("===============================");
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