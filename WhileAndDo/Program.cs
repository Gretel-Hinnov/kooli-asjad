namespace WhileAndDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
             Console.WriteLine("i = {0}", i);
                i++;
            } while (i < 20);
        }
    }
}
