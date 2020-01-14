using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherProject
{
    public class GetSmallValues
    {
        public static int[] GetOnlySmallValues(int[] values)
        {
            var x = 0;
            foreach (var value in values)
            {
                if (value < 5)
                {
                    ++x;
                }
            }
            
            int[] smallValues = new int[x];
            var j = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < 5)
                {
                    smallValues[j] = values[i];
                    ++j;
                }
            }

            return smallValues;
        }
    }
}
// Izveidot static metodi GetOnlySmallValues, kura atrodas atsevišķā projektā(Library projekts) un 
// atsevišķā failā. Metodei , kā parametru ir jāsaņem int[] un jāatgriež atpakaļ int[], kurā atrodas 
// visas vērtības, kuras mazākas par 5;