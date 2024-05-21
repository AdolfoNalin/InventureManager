
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoquePOO
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            HelpersProducts.Loanding();
            int num = 0;
            do
            {
                num = Menu.PresentationMenu();
                Menu.menu input = (Menu.menu) num;
                switch(input)
                {
                    case Menu.menu.Consult:
                        HelpersProducts.List();
                        break;
                    case Menu.menu.Save:
                        break;
                    case Menu.menu.Delete:
                        break;
                    case Menu.menu.Imput:
                        Menu.InsertPhysicalProductMenu();
                        break;
                    case Menu.menu.Output:
                        break;
                    default:
                        Console.WriteLine("Please, Choose a correct option!");
                        break;
                }
                Console.Clear();
            }
            while(!((Menu.menu) num == Menu.menu.Exit));
        }
    }
}