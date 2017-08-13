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
            Encrypt en = new En0(Console.ReadLine());

            Console.WriteLine(en.DePass());
            Console.ReadLine();
        }
        
        
    }
}
