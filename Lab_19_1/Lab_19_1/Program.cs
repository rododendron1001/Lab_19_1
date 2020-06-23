using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



namespace Lab_19_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Generare numere intregi de la 0 la 35 :");
            Console.WriteLine("Numarul intreg maxim dorit : ");

            bool r = int.TryParse(Console.ReadLine(), out int n);
            if (r)
            {
                foreach (long number in IntegerNumbers.IntIterator(n))
                {
                    Console.WriteLine(number);
                }

                Console.WriteLine();


                Console.WriteLine($"Generare numere impare de la 0 la n :");
                var oddNumbers = new OddNumbersEnumerable(IntegerNumbers.IntIterator(n));
                foreach (int number in oddNumbers)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Numarul introdus nu este intreg  {n} ");
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

                    if (i == n+1)                     
                  
                        {
                        //Console.WriteLine($"S-au generat numerele intregi de la 0 la {n}");

                            yield break;
                        }
                    
                    yield return N;
                }
            }
        }


        public class OddNumbersEnumerable : IEnumerable<long>
        {
            private readonly IEnumerable<long> elements;

            public OddNumbersEnumerable(IEnumerable<long> elements)
            {
                this.elements = elements ?? Enumerable.Empty<long>();
            }

            public IEnumerator<long> GetEnumerator()
            {
                return this.GetOddNumbersEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetOddNumbersEnumerator();
            }

            protected IEnumerator<long> GetOddNumbersEnumerator()
            {
                foreach (var number in this.elements)
                {
                    if  (number % 2 == 1)
                    {
                        yield return number;
                    }
                }
            }
        }

        
    }
}
