using System.Linq;

/*
        Simple Encryption #1 - Alternating Split

        For building the encrypted string:
       Take every 2nd char from the string. Then the other chars.
       Do this n times!

       Examples:

       "This is a test!", 1 -> "hsi  etTi sats!"
       "This is a test!", 2 -> "hsi  etTi sats!" -> "s eT ashi tist!"

       Write two methods:

       string Encrypt(string text, int n)
       string Decrypt(string encryptedText, int n)

       For both methods:
       If the input-string is null or empty return exactly this value!
       If n is <= 0 then return the input text.
       */

public class Kata
{
    public static string Encrypt(string text, int n)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        while (n-- > 0)
        {
            var encrypt = new string(text.Where((ch, index) => index % 2 != 0).ToArray());
            var rest = new string(text.Where((ch, index) => index % 2 == 0).ToArray());

            text = encrypt + rest;
        }

        return text;
    }

    public static string Decrypt(string encryptedText, int n)
    {
        if (string.IsNullOrEmpty(encryptedText) || n == 0)
        {
            return encryptedText;
        }

        var decryptedText = new char[encryptedText.Length];

        while (n-- > 0)
        {
            for (int i = 0; i < decryptedText.Length; i++)
            {
                var index = i < decryptedText.Length / 2
                    ? (i * 2) + 1
                    : (i - (decryptedText.Length / 2)) * 2;

                decryptedText[index] = encryptedText[i];
            }

            encryptedText = new string(decryptedText);
        }

        return encryptedText;
    }
}