using System.Net.WebSockets;

namespace LINQGroupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");

            GroupByLINQ();
            Console.WriteLine("_____________________________");
            ToLookupLINQ();
        }

        public static void GroupByLINQ()
        {
            var result = PeopleList.peoples.GroupBy(x => x.Age);

            foreach (var people in result)
            {
                Console.WriteLine("Age group: ", people.Key);

                foreach (var p in people)
                {
                 Console.WriteLine("People name: " + p.Name);
                }
            }

            
        }
        public static void ToLookupLINQ()
        {
            var result = PeopleList.peoples.ToLookup(s => s.Age);
            
            foreach (var l in result)
            {
                Console.WriteLine(l.Key);

                foreach (var i in l)
                {
                    Console.WriteLine(" "+ i.Age);
                }

            }
        }
    }
}