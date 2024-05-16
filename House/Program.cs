using System.Drawing;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjuta mingi number");
            House();
            Diamond();
        }
        static void House()
        {

            int size = int.Parse(Console.ReadLine());
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("_");
                }
                Console.WriteLine();
            }

            for (int row = 1; row < size; row++)
            {
                for (int column = 1; column <= size * 2; column++)
                {
                    string mark;

                    if (row == column || row + column <= size + 1)
                    {
                        mark = "|";
                    }
                    else
                    {
                        mark = "|";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }

        }
        static void Diamond()
        {
            int i, j, n;
            Console.WriteLine("Sisiesta püramiidi suurus");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (i = n - 1; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
        }
    }
}
    




