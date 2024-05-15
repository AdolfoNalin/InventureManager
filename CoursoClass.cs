using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    public class CoursoClass : Product
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
    }
}