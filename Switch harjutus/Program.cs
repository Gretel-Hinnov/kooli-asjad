namespace harjutus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("kirjuta number");
            int boop = int.Parse(Console.ReadLine());



            if (boop == 30)
            {
                Jah();
                Console.WriteLine(boop);
            }
            else
            {
                Console.WriteLine("ei :(");
            }
        
        }
        static void Jah()
        {
            int boop = 30;
            switch (boop)
            {
                case 1:
                    Console.WriteLine("esimene");
                    break;
                case 2:
                    Console.WriteLine("teine");
                    break;
                case 3:
                    Console.WriteLine("kolmas");
                    break;
                default:
                    Console.WriteLine("neljas");
                    break;
            }
        }
    }
}
