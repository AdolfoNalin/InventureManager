using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    public class HelpersProducts
    {
        static List<IStock> stocks = new List<IStock>();
        #region  Insert into CC 
        public static void InserCoursoClass()
        {
           string name,author,description;
           float price;
           Console.WriteLine("*****Inser-into-the-Courso-Class*****"); 
           Console.Write("What's name of Couse? ");
           name = Console.ReadLine();
           Console.Write("\nWhat name of the Author? ");
           author = Console.ReadLine();
           Console.Write("\nWhat description of the courso? ");
           description = Console.ReadLine();
           Console.Write("\nWhat is price? R$");
           price = float.Parse(Console.ReadLine());
           CoursoClass cc = new CoursoClass(name, description,author, price);
           stocks.Add(cc);
        }
        #endregion

        #region Insert into Ebook
        public static void InserEbook()
        {
           string name,author,description;
           float price, memory;
           Console.WriteLine("*****Inser-into-the-Ebook*****"); 
           Console.Write("Waht's name of Courso? ");
           name = Console.ReadLine();
           Console.Write("\nWhat's name of Author? ");
           author = Console.ReadLine();
           Console.Write("\nWhat is Description? ");
           description = Console.ReadLine();
           Console.Write("\nWhat is Price? R$");
           price = float.Parse(Console.ReadLine());
           Console.Write("\nHow much is memory? ");
           memory = float.Parse(Console.ReadLine());

           Ebook eb = new Ebook(name, description, author, price,memory);
           stocks.Add(eb);
        }
        #endregion

        #region Insert into PP
        public static void InserPhysicalProduct()
        {
            string name,description;
            float price, freightage;
            Console.WriteLine("*****Insert-into-the-Physical-Product");
            Console.Write("What`s name of Physical Product? ");
            name = Console.ReadLine();
            Console.Write("Waht's the Description of the Physical Product? ");
            description = Console.ReadLine();
            Console.Write("What's the Price of the Physical Product? R$");
            price = float.Parse(Console.ReadLine());
            Console.Write("What's the freightage value? R$");
            freightage = float.Parse(Console.ReadLine());
            PhysicalProduct pp = new PhysicalProduct(name, description, price, freightage);
            stocks.Add(pp);
        }
        #endregion
    }
}