using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "(((())))";

            if (Method.IsBalanced(input) ==true)
                Console.WriteLine($"\n\t Input '{input}' is BALANCED!!");
            else
                Console.WriteLine($"\n\t Input '{input}' is NOT balanced!");

            Console.ReadLine();
        }
    }
}
