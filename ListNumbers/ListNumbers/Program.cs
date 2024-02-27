namespace ListNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Massiiv e Array");
            int[] numbers = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("----------------------------------------");

            
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine(numbers[j] +10);
            }
        }
    }
}