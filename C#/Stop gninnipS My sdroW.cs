using System.Collections.Generic;
using System.Linq;
using System;

/*
Stop gninnipS My sdroW!

Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.
*/
public class Kata
{
    public static string SpinWords(string sentence)
    {
        return string.Join(" ", sentence.Split(' ').Select(i =>
        {
            if (i.Length >= 5)
                return string.Join("", i.ToArray().Reverse());

            return i;
        }));
    }
}