using System.Runtime.CompilerServices;

namespace File12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta faili läbi konsooli");

            string filePath = @"C:\Users\opilane\Desktop/dokument.txt";
            string inputText = Console.ReadLine();
            File.WriteAllText(filePath, inputText);
        }
    }
}
