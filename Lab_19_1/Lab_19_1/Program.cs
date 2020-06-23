using System;
using System.Collections;
using System.Collections.Generic;

//Scrieti un iterator care sa furnizeze toate numerele de la 0 pana la numarul maxim reprezentabil in memorie pentru 
//tipurile intregi.Folositi yield return si yield break pentru a obtine comportamentul dorit.

namespace Lab_19_1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (long number in IntegerNumbers.IntIterator(35))
            {
                Console.WriteLine(number);
            }
        }

        public static class IntegerNumbers
        {

            public static IEnumerable<long> IntIterator(int n)
            {
                yield return 0;
                int N = 0;

                for (int i = 1; i < int.MaxValue; i++)
                {
                    N++;
                    if (i == n)
                  
                        {
                            yield break;
                        }

                    
                    yield return N;

                }
            }
        }
    }
}
