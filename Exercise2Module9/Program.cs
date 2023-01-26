using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Module9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LastNameContainer lastNameContainer = new LastNameContainer();

            Console.WriteLine("Please add 5 last names to the collection");
            for (int i = 0; i < 5; i++)
            {
                lastNameContainer.AddLastName(Console.ReadLine());
            }
            Console.WriteLine("Enter 0 or 1 to order the last names");

            lastNameContainer.Sort(int.Parse(Console.ReadLine()));

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
