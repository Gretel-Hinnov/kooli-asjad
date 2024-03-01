using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "#CD5C5C";
            Console.WriteLine("Hex code: " + word);
            Console.WriteLine("kas on regex: " + RegExTest(word));
        }

        public static bool RegExTest (string word)
        {
            return Regex.IsMatch (word, @"[#] [0-9A-Fa-f] {6} \b");
        }
    }
}