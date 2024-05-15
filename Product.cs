using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}