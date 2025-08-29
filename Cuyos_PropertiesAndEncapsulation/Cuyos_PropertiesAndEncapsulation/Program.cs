using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_PropertiesAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Louis Aian Cuyos
            // IT306
            // EXER_05: Applying Encapsulation with User


            // Instantiate of an Object Class
            Shirt myshirt = new Shirt();
            Console.ForegroundColor = ConsoleColor.Yellow;
             

            myshirt.Name = "Nike";  // Set Name Property
            myshirt.Color = "Black"; // Set Color Property

            // Call Method to Display
            myshirt.DisplayDetails();

            Console.ReadKey();
        }
    }
}
