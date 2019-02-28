using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs24Homework
{
    public class Exercise02
    {
        public static void ArePermutation(string sir1, string sir2)
        {
            bool estePermutare;

            if (sir1 == null || sir2 == null)
                estePermutare = false;
            if (sir1.Length != sir2.Length)
                estePermutare = false;

            char[] sir1arr = sir1.ToCharArray();
            char[] sir2arr = sir2.ToCharArray();

            Array.Sort(sir1arr);
            Array.Sort(sir2arr);

            for (int i = 0; i < sir1.Length - 1; i++)
            {
                if (sir1arr[i] != sir2arr[i])
                    estePermutare = false;
            }
            estePermutare = true;

            if (estePermutare == true)
                Console.WriteLine($"\n\t Ex.2. Sirul '{sir2}' ESTE permutare a sirului '{sir1}'.");
            else
                Console.WriteLine($"\n\t Ex.2. Sirul '{sir2}' NU ESTE permutare a sirului '{sir1}'.");
        }
    }
}
