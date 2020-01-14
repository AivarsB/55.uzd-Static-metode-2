using AnotherProject;
using System;

namespace _55.uzd_Static_metode_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] blablabla = GetSmallValues.GetOnlySmallValues(allValues);

            foreach (var bla in blablabla)
            {
                Console.WriteLine(bla);
            }
        }
    }
}
// Izveidot static metodi GetOnlySmallValues, kura atrodas atsevišķā projektā(Library projekts) un 
// atsevišķā failā. Metodei , kā parametru ir jāsaņem int[] un jāatgriež atpakaļ int[], kurā atrodas 
// visas vērtības, kuras mazākas par 5;