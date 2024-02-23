namespace ListFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            Console.WriteLine("Number of elements: " + primeNumbers.Count);
            Console.WriteLine();
        }
    }
}