using UnityEngine;

public static class ArrayExtends
{

    public static int? FindIndex<T>(this T[] array, T item)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i].Equals(item))
                return i;
        }
        Debug.LogError(item + " is not in the " + array);

        return null;
    }


}
