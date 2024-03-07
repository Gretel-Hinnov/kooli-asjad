using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace FindWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta otsitav sõna");

            Console.WriteLine("Kasuta formaati 's--a'" +
            "kus- tähistab tundmatut tähte");

            string choice = Console.ReadLine();

            WordFinder(choice);
        }
        private static void WordFinder(string choice)
        {
            Regex regularExp = new Regex(@"\b" + choice.Replace("-", "\\w"),
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/lemmad.txt", Encoding.Default))
                {
                     int lineNumber = 0;

                     while(sr.EndOfStream == false)
                     {

                        string line = sr.ReadLine();

                        if(line.Length== choice.Length)
                        {
                          
                            MatchCollection matchCollection = regularExp.Matches(line);
                
                            if(matchCollection.Count >0)
                            {
                                lineNumber++;
                        
                                Console.WriteLine(lineNumber + "" + line);
                            }
                        }
                     
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {        
                throw;
            }
        }
    }
}