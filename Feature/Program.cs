
using System.Collections.Generic;

namespace Feature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tuples example 

            //Without names 
            (double, int) t1 = (4.5, 3);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");

            //With Names 
            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");



            //Returns from functions

            var t3 = new TupleExample().ReturnsTwoNumbers();
            Console.WriteLine($"Sum of {t3.Item1} elements is {t3.Item2}.");






            //Extension method 

            Console.WriteLine( DateTime.Now.ClientSpecificDateFormat());

            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var abc = list.ConvertToArray();








            // Lambda expression



            var res = list.Find(delegate (int n)
            {
                if (n == 5) return true;
                else return false;
            });


            var res2 = list.Find(x => x == 5);

            var res3 = list.Find(x =>
            {
                return x >5 ? true:false;
            });
        }
    }
}