using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace omregninger
{
    class NewProject
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main");
           
            Count();
            Console.WriteLine("main");
            Console.ReadKey();

        }
        public static void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);

            }

        }
    }
}
