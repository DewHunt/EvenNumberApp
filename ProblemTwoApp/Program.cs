using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All Even Numbers From 1 to 100 are : ");
            Console.Write("\n\t");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
            }

            Console.ReadKey();
        }
    }
}
