namespace ArraySortNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "cat", "alligator", "fox", "donkey", "bear", "elephant", "goat" };

           //Array.Sort(animals);

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("---------------------------------");

            Array.Sort(animals, 0, 3);

            foreach (var animal in animals )
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("--------------------------------");

            int[] numbers = {1, 2, 3, 4, 3, 55, 23, 2 };
            IEnumerable<int> distinctNumbers = numbers.Distinct().ToList();

            foreach (int number in distinctNumbers)
            {
                Console.WriteLine(number + " ");
            }
        }
    }
}