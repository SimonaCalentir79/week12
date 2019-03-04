using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cents
{
    public class Method
    {
        public static void CoinsCombinations(int sum)
        {
            int quarter = 25, dime = 10, nikel = 5, cent = 1;

            int noOfQuarters = sum / quarter;
            int noOfDimes = (sum - noOfQuarters * quarter) / dime;
            int noOFNikels = (sum - noOfQuarters * quarter - noOfDimes * dime) / nikel;
            int noOfCents = (sum - noOfQuarters * quarter - noOfDimes * dime - noOFNikels * nikel) / cent;

            for (int q = noOfQuarters; q >=0 ; q--)
            {
                noOfDimes = (sum - q * quarter) / dime;

                for (int d = noOfDimes; d >= 0; d--)
                {
                    noOFNikels = (sum - q * quarter - d * dime) / nikel;

                    for (int n = noOFNikels; n >= 0; n--)
                    {
                        noOfCents = (sum - q * quarter - d * dime - n * nikel) / cent;

                        Console.WriteLine($"\n\t Sum {sum} = {q} quarters + {d} dimes + {n} nikels + {noOfCents} cents.");
                    }
                }
            }
        }
    }
}
