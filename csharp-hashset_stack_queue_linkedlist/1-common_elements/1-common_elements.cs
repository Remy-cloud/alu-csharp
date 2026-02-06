using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> common = new HashSet<int>();

        foreach (int num in list2)
        {
            if (set1.Contains(num))
            {
                common.Add(num);
            }
        }

        List<int> result = new List<int>(common);
        result.Sort();

        return result;
    }
}