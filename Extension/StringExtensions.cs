using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Hangman.Extension
{
    public static class StringExtensions
    {
        public static byte[] GetSHA256Hash(this string inputString)
        {
            return SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(inputString));
        }

        public static string GetSHA256HashString(this string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return inputString;
            }

            return Convert.ToBase64String(GetSHA256Hash(inputString))
                .Split('=')[0]
                .Replace('+', '-')
                .Replace('/', '_');
        }
    }
}
