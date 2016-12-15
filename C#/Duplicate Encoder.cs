using System.Text;
using System.Linq;

/*
Duplicate Encoder

Description:

The goal of this exercise is to convert a string to a new string where each character in the new string is '(' if that character appears only once in the original string, or ')' if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

Examples:

"din" => "((("

"recede" => "()()()"

"Success" => ")())())"

"(( @" => "))(("

*/
public class Kata
{
    public static string DuplicateEncode(string word)
    {
        var result = new StringBuilder();
        var charArray = word.ToLower().ToCharArray();

        foreach (var c in charArray)
        {
            if (charArray.Count(i => i == c) == 1)
                result.Append('(');
            else
                result.Append(')');
        }

        return result.ToString();
    }
}