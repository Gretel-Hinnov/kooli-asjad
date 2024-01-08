namespace ForLoopMultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");
            int j, i, n;

            Console.WriteLine("sisesta tabelisse number, millest soovid alustada");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("korrutustabel ühest kuni {0}", n);
            Console.WriteLine("\n");

            for (i= 1; i < 10; i++) 
            { 
                for (j =1; j <= n; j++)
                { 

                    if (j <= n-1)
                    {
                        Console.Write("{0}x{1} = {2}", j, i , i* j);
                    }
                    else
                    {
                        Console.Write("{0}x{1} = {2}", j, i, i * j);
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}