using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_EncapsulationUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:
            // Louis Aian Cuyos
            // IT306
            // EXER_05: Applying Encapsulation with User


            // Instantiate of an Object Class
            Shirt myshirt = new Shirt();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t\tEnter the Brand and Color of the Shirt that you want");

            // User Input
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n\nEnter the Brand of your Shirt : ");
            myshirt.Name = Console.ReadLine();

            Console.Write("Enter the Color of you Shirt  : ");
            myshirt.Color = Console.ReadLine();

            // Call Method to Display
            myshirt.DisplayDetails();

            Console.ReadKey();

            // If you want to input again
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nEnter if you want more (Y/N)");
            char i = Convert.ToChar(Console.ReadLine());

            if (i == 'Y')
            {
                goto Main;
            }
            else
            {
                return;
            }
        }
    }
}
