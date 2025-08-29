using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_EncapsulationUserInput
{
    internal class Shirt
    {
        // Encap Properties for Fields
        public string Name { get; set; }
        public string Color { get; set; }



        // Method to Display shirt details
        public void DisplayDetails()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Color


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t******** Here are the Details of the Shoes you inputed *********");
            Console.WriteLine("\nEnter the Brand of your shoes: " + Name);
            Console.WriteLine("Enter the Color of your shoes: " + Color);

        }
    }
}
