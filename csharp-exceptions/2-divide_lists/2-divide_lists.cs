using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                int value1 = list1[i];
                int value2 = list2[i];

                try
                {
                    int division = value1 / value2;
                    result.Add(division);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    result.Add(0);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }

        return result;
    }
}
