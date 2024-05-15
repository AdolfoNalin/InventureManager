
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    public class Program
    {
        enum menu {Consult = 1, Add, Delete, Insert, Output,Exit = 0}
        static void Main(string[] args)
        {
            Console.WriteLine("=====Welcome-to-Inventure-Manager=====");

            Console.WriteLine("*****Choose-an-option*****");
            Console.WriteLine($"1-{menu.Consult}, 2-{menu.Add}, 3-{menu.Delete}, 4-{menu.Insert}, 5-{menu.Output}, 0-{menu.Exit}");
            int num = int.Parse(Console.ReadLine());
            menu imput = (menu) num;

            while(!((menu) num == menu.Exit))
            {
                switch(imput)
                {
                    case menu.Consult:
                    Console.WriteLine("the function are working");
                        break;
                    case menu.Add:
                        break;
                    case menu.Delete:
                        break;
                    case menu.Insert:
                        break;
                    case menu.Output:
                        break;
                    default:
                        Console.WriteLine("Please, Choose a correct option!");
                        break;
                }
            }
        }
    }
}