using System.Collections.Generic;
using UnityEngine;

public static class ListExtends
{

    public static void AddUnique<T>(this List<T> list, T item)
    {
        if (!list.Contains(item))
            list.Add(item);
    }

    public static int FindIndex<T>(this List<T> list, T item)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Equals(item))
            {
                return i;
            }
        }

        Debug.LogError(item + " is not found in " + list);
    
        return -1;
    }

}
