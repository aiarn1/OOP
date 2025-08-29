using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuyos_PropertiesAndEncapsulation
{
    internal class Shirt
    {
        // Encap Properties for Fields
        private string name;
        private string color;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }



        // Method to Display shirt details
        public void DisplayDetails()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Color


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
     
            Console.WriteLine("\nName : " + Name);
            Console.WriteLine("Shoes : " + Color);

        }
    }
}
