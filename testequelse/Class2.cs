using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        
        int[] c = new int[2];
        if (input.Length == 0 || input[0] == null)
        {
            return new int[] { };
        }

        if (input.Length == 1 && input[0] == 0)
        {
            return new int[] { };
        }



        foreach (int x in input)
        {
            if (x > 0)
            {
                c[0] ++;
            }
            else
            {
                c[1] += x;
            }
        }
        
        return c; //return an array with count of positives and sum of negatives
    }
}