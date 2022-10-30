using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPizzaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input;

            Console.WriteLine("Hello and Welcome to Fast Pizza");
            Console.WriteLine("First choose which restuarant you want to order from:");
            for (int i = 1; i < args.Length; i++) // writing the resturants
            {
                Console.WriteLine(i + ":" + i);
            }        

            input = Console.ReadKey().KeyChar;

            Console.WriteLine("\n" + input);

            if (input == 0) // check if the user input matches with a resturant 
            {

            } 

                Console.WriteLine("Choose which item you want to order:");
            for (int i = 1; i < args.Length; i++) // writing the menu
            {

            }
            input = Console.ReadKey().KeyChar;

            Console.WriteLine("\n" + input);

            Console.WriteLine("you have ordered " + input);
            Console.WriteLine("Do you want to confirm your order?");
            Console.WriteLine("1. Yes \n 2. No");
            Console.ReadKey();


        }
    }
}
