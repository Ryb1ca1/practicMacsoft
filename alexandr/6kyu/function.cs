using System;
using System.Linq;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        
        var so = Where(n => n % 2 != 0).OrderBy(n => n).ToArray();
        
        
        int oddIndex = 0;

        return array.Select(n => n % 2 == 0 ? n : so[oddIndex++]).ToArray();
    }
}