using System;
using System.Linq;

/*
 * Are they the "same"?
 * 
 Given two arrays a and b write a function comp(a, b) (compSame(a, b) in Clojure) that checks whether the two arrays have the "same" elements, 
 with the same multiplicities. "Same" means, here, that the elements in b are the elements in a squared, regardless of the order.
 */

class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        if (a == null || b == null)
            return false;

        if (a.Length == 0 && b.Length == 0)
            return true;

        if (a.Length == 0 || b.Length == 0)
            return false;

        a = a.OrderBy(i => i).ToArray();
        b = b.OrderBy(i => i).ToArray();

        for (var i = 0; i < b.Length; ++i)
        {
            if (a[i] * a[i] != b[i])
                return false;
        }


        // your code
        return true;
    }
}
