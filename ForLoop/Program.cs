using System.Drawing;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjuta mingi number");
            House();
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
    }
    

}


