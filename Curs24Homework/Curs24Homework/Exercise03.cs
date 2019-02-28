using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs24Homework
{
    public static class Exercise03
    {
        public static void OneOrZeroEditsAway(string sir1, string sir2)
        {
            bool OneEditAway;
            if (sir1 == null || sir2 == null)
                OneEditAway= false;
            if (sir1.Equals(sir2))
                OneEditAway= false;

            int len1 = sir1.Length;
            int len2 = sir2.Length;

            if (Math.Abs( len1 - len2) > 1)
                OneEditAway= false;


            char[] sir1arr = sir1.ToCharArray();
            char[] sir2arr = sir2.ToCharArray();
            Array.Sort(sir1arr);
            Array.Sort(sir2arr);
            int i = 0, j = 0, counter = 0;

            while (i < len1 && j < len2)
            {
                if (sir1arr[i] != sir2arr[j])
                {
                    if (counter == 1) OneEditAway= false;

                    if (len1 < len2) j++;
                    else if (len1 > len2) i++;
                    else
                    {
                        i++;
                        j++;
                    }
                    counter++;
                }
                else
                {
                    i++;
                    j++;
                }
            }
            if (i < len1 || j < len2)
                counter++;
            OneEditAway = counter == 1;

            if (OneEditAway == true)
                Console.WriteLine($"\n\t Ex.3. Intre sirurile '{sir1}' si '{sir2}' este diferenta de 1 caracter!");
            else
                Console.WriteLine($"\n\t Ex.3. Intre sirurile '{sir1}' si '{sir2}' este diferenta de mai multe caractere!");
        }
    }
}
