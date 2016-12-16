using System;
using System.Linq;

/*
Credit Card Mask

Description:

Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

Your task is to write a function maskify, which changes all but the last four characters into '#'.
*/
public static class Kata
{
    // return masked string
    public static string Maskify(string cc)
    {
        return cc.Length < 5
         ? cc
         : new string('#', cc.Length - 4) + new string(cc.Skip(cc.Length - 4).ToArray());
    }
}