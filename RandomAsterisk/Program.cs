namespace RandomAsterisk_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stringRowMin = 0;
            int stringRowMax = 5;

            int[] randomAsterisk = new int[stringRowMax];

            Random asterisk = new Random();

            for (int i = stringRowMin; i < randomAsterisk.Length; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("*",
                    asterisk.Next(1,20))));
            }
            Console.WriteLine("-----------------------------------------");

            foreach (int i in randomAsterisk)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("*",
                  asterisk.Next(1, 20))));
            }
        }
    }
}