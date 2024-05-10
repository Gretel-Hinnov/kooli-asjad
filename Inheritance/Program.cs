namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert two numbers: ");
            Console.WriteLine("First number: ");
            int firstNr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First number: ");
            int secondtNr = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(firstNr);
            rectangle.SetHeight(secondtNr);

            Console.WriteLine("Total area: {0}", rectangle.GetArea());
        }
    }
    class Shape
    {
        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }

        protected int width;
        protected int height;
    }
    class Rectangle : Shape
    {
        public int GetArea()
        {
            return width * height;
        }
    }
}
