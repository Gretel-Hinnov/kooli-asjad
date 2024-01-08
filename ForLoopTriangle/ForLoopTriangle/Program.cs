namespace ForLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest tehtud kolmnurk e poolik püramiid:");
            Console.WriteLine("-----------------------------------------------");

            
            int val = 10;
            Console.Write("Sisesta ridade arv : ");
            val = Convert.ToInt32(Console.ReadLine());
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    // Console.Write("");  
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
