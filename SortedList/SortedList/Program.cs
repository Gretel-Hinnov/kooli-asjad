namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted list");

            SortedList<int, string> numberNames = new SortedList<int, string>();

            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            foreach (var number in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", number.Key, number.Value);
            }


        }
    }
}