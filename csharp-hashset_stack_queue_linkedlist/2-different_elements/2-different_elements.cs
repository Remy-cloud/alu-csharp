using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        HashSet<int> different = new HashSet<int>();

        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                different.Add(num);
            }
        }

        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                different.Add(num);
            }
        }

        List<int> result = new List<int>(different);
        result.Sort();

        return result;
    }
}