using System;
using System.Linq;

namespace AlgorithmTest
{
    public static class Helper
    {
        private static Random random = new Random();
        public static string GenerateValue(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(c => c[random.Next(c.Length)]).ToArray());
        }
    }
}
