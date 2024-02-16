namespace DictionaryForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Dictionary Foreach");
            var domains = new Dictionary<string, string>()
            {
                {"est -", "Estonia"},
                {"lat -", "Latvia"},
                {"fin -", "Finland"},
                {"swe -", "Sweden"}
            };
           
            foreach (var domain in domains )
            {
                Console.WriteLine($" {domain.Key}- {domain.Value} - {i}");
                i++;
            }
        }
    }
}