using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    public class CoursoClass : Product,IStock
    {
        public string Author { get; set; }
        public int Vacancies {get; private set;}
        public CoursoClass(string name, string description, string author, float price) : base(name, description, price)
        {
            this.Name = name;
            this.Description = description;
            this.Author = author;
            this.Price = price;
        }

        public void GetInformationProduct()
        {
            Console.WriteLine($"Name: {this.Name}\nDescription: {this.Description}" +
            $"\nPrice: {this.Price}\nFreightage: {this.Author}\nRestant Vacancies: {this.Vacancies}");
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