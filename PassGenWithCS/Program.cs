using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string str = checkEn.StartEn();
            Console.Write("Your code: " + str);
            
            //File.WriteAllText(@"d:\programming\c#\test.txt", str);




            //string str = File.ReadAllText(@"d:\programming\c#\test.txt");
            //CheckEn checken = new CheckEn(str, "1451400181547369693", "d");
            //string x = checken.StartEn();
            //Console.WriteLine(x);




            Console.ReadLine();
        }
        
        
    }
}