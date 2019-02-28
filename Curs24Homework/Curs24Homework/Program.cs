using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs24Homework
{
    public class Program
    {
        static void Main()
        {
            //------------------ Exercitiul 1 ------------------\\

            var listOfInt = Exercise01.listOfIntegers();
            Node<int> node1 = listOfInt.nthToLast(listOfInt.Head, 3);
            Console.WriteLine($"\n\t Ex.1. Al 3-lea element de la sfarsitul listei este: '{node1.Data.ToString()}'.");

            var listOfStrings = Exercise01.listOfStrings();
            Node<string> node2 = listOfStrings.nthToLast(listOfStrings.Head, 3);
            Console.WriteLine($"\n\t Ex.1. Al 3-lea element de la sfarsitul listei este: '{node2.Data.ToString()}'.");

            //------------------ Exercitiul 2 ------------------\\

            string sir1 = "albastru";
            string sir2 = "abalstru";

            Exercise02.ArePermutation(sir1, sir2);

            //------------------ Exercitiul 3 ------------------\\

            string sir3 = "pale";
            string sir4 = "pal";

            Exercise03.OneOrZeroEditsAway(sir3, sir4);

            //------------------ Exercitiul 4 ------------------\\

            string sir5 = "abxcdyefzgh";
            string sir6 = "yxz";

            Exercise04.FindPermutation(sir5,sir6);

            //--------------------------------------------------\\

            Console.ReadLine();
        }
    }
}
