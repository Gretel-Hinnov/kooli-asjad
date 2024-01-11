namespace ForLoopSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruut");
            Console.WriteLine("Sisesta ruudu suurus");
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row < size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;

                    if (row == column || row + column <= size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}