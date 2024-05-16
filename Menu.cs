using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    public class Menu
    {
        public enum menu {Exit, Consult, Save, Delete, Imput,Output}
        private enum option {Exit, PP, Ebook, CC}
        public static menu MenuEnum {get; private set;}
        public static int PresentationMenu()
        {
            Console.WriteLine("=====Welcome-to-Inventory-Manager=====");

            Console.WriteLine("*****Choose-an-option*****");
            Console.WriteLine($"1-{menu.Consult}, 2-{menu.Save}, 3-{menu.Delete}, 4-{menu.Imput}, 5-{menu.Output}, 0-{menu.Exit}");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        private static int InsertMenu()
        {
            Console.WriteLine("Insert of Product");
            Console.WriteLine($"1-Physical Product\n2-Ebook\n3-Course Class\n0-Exit");
            int select = int.Parse(Console.ReadLine());
            return select;
        }
        public static void InsertPhysicalProductMenu()
        {
            int num = 0;
            do
            {
                option op = (option) InsertMenu();
                switch(op)
                {
                    case option.PP:
                        HelpersProducts.InserPhysicalProduct();
                        break;
                    case option.Ebook:
                        HelpersProducts.InserEbook();
                        break;
                    case option.CC:
                        HelpersProducts.InserCoursoClass();
                        break;
                    default:
                        Console.WriteLine($"Option {op} is not supported.");
                        break;
                }
            }
            while((option) num != option.Exit);
        }
    }
}