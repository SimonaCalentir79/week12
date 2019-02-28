using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs24Homework
{
    public class Exercise04
    {
        public static void FindPermutation(string sir1, string sir2)
        {
            bool esteAnagarama;
            string shorter, longer;

            if (sir1.Length > sir2.Length)
            {
                longer = sir1;
                shorter = sir2;
            }
            else
            {
                longer = sir2;
                shorter = sir1;
            }

            char[] shorterArr = shorter.ToCharArray();
            char[] longerArr = longer.ToCharArray();
            int counter = 0;
            Dictionary<int, string> pairs = new Dictionary<int, string>();

            for (int i = 0; i < shorter.Length; i++)
            {
                for (int j = 0; j < longer.Length - 1; j++)
                {
                    if (shorterArr[i] == longerArr[j])
                    {
                        counter++;
                        pairs.Add(j + 1, longerArr[j].ToString());
                    }
                }
            }
            if (counter == shorter.Length)
                esteAnagarama = true;
            else
                esteAnagarama = false;

            if (esteAnagarama == true)
            {
                Console.WriteLine($"\n\t Ex.4. Sirul '{shorter}' ESTE anagramat in sirul '{longer}'.");
                foreach (var val in pairs)
                    Console.WriteLine($"\n\t\t Caracterul '{val.Value}' se afla la pos. '{val.Key}'.");
            }
            else
                Console.WriteLine($"\n\t Ex.4. Sirul '{shorter}' NU ESTE anagramat in sirul '{longer}'.");
        }
    }
}
