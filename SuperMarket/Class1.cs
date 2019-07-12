using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class MyClass
    {
        static Random rdn = new Random((int)DateTime.Now.Ticks);
        public string GenerateToken(int length)
        {
            RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider();
            byte[] tokenBuffer = new byte[length];
            cryptRNG.GetBytes(tokenBuffer);
            return Convert.ToBase64String(tokenBuffer);
        }

        public static string GetRandomAlphaNumeric()
        {
            return Path.GetRandomFileName().Replace(".", "").Substring(0, 8);
        }

        public static string GetRandomAlphaNumeric2()
        {
            var chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(chars.Select(c => chars[rdn.Next(chars.Length)]).Take(8).ToArray());
        }
          
        public static IEnumerable<char> To(this char start, char end)
        {
            if (end < start)
                throw new ArgumentOutOfRangeException("the end char should not be less than start char", innerException: null);
            return Enumerable.Range(start, end - start + 1).Select(i => (char)i);
        }

        public static string GetRandomAlphanumericString(int length)
        {
            const string alphanumericCharacters =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789";
            return GetRandomString(length, alphanumericCharacters);
        }

        public static string GetRandomString(int length, IEnumerable<char> characterSet)
        {
            if (length < 0)
                throw new ArgumentException("length must not be negative", "length");
            if (length > int.MaxValue / 8) // 250 million chars ought to be enough for anybody
                throw new ArgumentException("length is too big", "length");
            if (characterSet == null)
                throw new ArgumentNullException("characterSet");
            var characterArray = characterSet.Distinct().ToArray();
            if (characterArray.Length == 0)
                throw new ArgumentException("characterSet must not be empty", "characterSet");

            var bytes = new byte[length * 8];
            new RNGCryptoServiceProvider().GetBytes(bytes);
            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                result[i] = characterArray[value % (uint)characterArray.Length];
            }
            return new string(result);
        }



        // what's available
        public static string possibleChars = "abcdefghijklmnopqrstuvwxyz";
        // optimized (?) what's available
        public static char[] possibleCharsArray = possibleChars.ToCharArray();
        // optimized (precalculated) count
        public static int possibleCharsAvailable = possibleChars.Length;
        // shared randomization thingy
        public static Random random = new Random();

        // http://stackoverflow.com/a/1344242/1037948
        public string LinqIsTheNewBlack(int num)
        {
            return new string(
            Enumerable.Repeat(possibleCharsArray, num)
                      .Select(s => s[random.Next(s.Length)])
                      .ToArray());
        }

        // http://stackoverflow.com/a/1344258/1037948
        public string ForLoop(int num)
        {
            var result = new char[num];
            while (num-- > 0)
            {
                result[num] = possibleCharsArray[random.Next(possibleCharsAvailable)];
            }
            return new string(result);
        }

        public string ForLoopNonOptimized(int num)
        {
            var result = new char[num];
            while (num-- > 0)
            {
                result[num] = possibleChars[random.Next(possibleChars.Length)];
            }
            return new string(result);
        }

        public string Repeat(int num)
        {
            return new string(new char[num].Select(o => possibleCharsArray[random.Next(possibleCharsAvailable)]).ToArray());
        }

        // http://stackoverflow.com/a/1518495/1037948
        public string GenerateRandomString(int num)
        {
            var rBytes = new byte[num];
            random.NextBytes(rBytes);
            var rName = new char[num];
            while (num-- > 0)
                rName[num] = possibleCharsArray[rBytes[num] % possibleCharsAvailable];
            return new string(rName);
        }

        //SecureFastRandom - or SolidSwiftRandom
        //static string GenerateRandomString2(int Length) //Configurable output string length
        //{
        //    byte[] rBytes = new byte[Length];
        //    char[] rName = new char[Length];
        //    SolidSwiftRandom.GetNextBytesWithMax(rBytes, biasZone);
        //    for (var i = 0; i < Length; i++)
        //    {
        //        rName[i] = charSet[rBytes[i] % charSet.Length];
        //    }
        //    return new string(rName);
        //}

    }
}
