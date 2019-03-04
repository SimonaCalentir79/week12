using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    public class Method
    {
        public static bool IsBalanced(string input)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
            {
                //{ '{','}'},
                //{ '[',']'},
                //{ '<','>'},
                { '(',')'}
            };

            Stack<char> brackets = new Stack<char>();
            try
            {
                foreach (char c in input)
                {
                    if (bracketPairs.Keys.Contains(c))
                    {
                        brackets.Push(c);
                    }
                    else
                    {
                        if (bracketPairs.Values.Contains(c))
                        {
                            if (c == bracketPairs[brackets.First()])
                            {
                                brackets.Pop();
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return brackets.Count() == 0 ? true : false;
        }
    }
}
