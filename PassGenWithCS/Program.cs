using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGenWithCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to Encrypt oe De crypt(E/D): ");
            String check = Console.ReadLine();

            Console.Write("Enter code: ");
            String input = Console.ReadLine();
            Console.Write("Enter order: ");
            String order = Console.ReadLine();


            CheckEn checkEn = new CheckEn(input, order, check);

            Console.Write("Your code: " + checkEn.StartEn());

            Console.ReadLine();
        }
        
        
    }
}
