using System.Xml.Linq;

namespace LINQwhileandtake
{
    internal class Program
    {
        static void Main(string[] args)
        
        
        
        {

            Console.WriteLine("kirjujta number:");
            Console.WriteLine("1 - skip LINQ");
            Console.WriteLine("2 - take LINQ");
            Console.WriteLine("3 - skip while LINQ");
            Console.WriteLine("4 - take while LINQ");
            Console.WriteLine("5 - First LINQ");
            Console.WriteLine("6 - First or default LINQ");
 
            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    SkipLINQ();
                    break;

                case 2:
                    TakeLINQ();
                    break;

                case 3:
                    SkipWhileLINQ();
                    break;

                case 4:
                    TakeWhileLINQ();
                    break;

                case 5:
                    FistLINQ();
                    break;

                case 6:
                    FirstOrDefaultLINQ();
                    break;


                default:
                    Console.WriteLine("valikut ei tehtud");
                    break;
            }

        }
        public static void SkipLINQ()
        {
            Console.WriteLine("Skip LINQ");

            var SkipAge = PeopleList.people;
            var outp = SkipAge.Skip(1);

            foreach (var yay in outp)
            {
                Console.WriteLine("id=" + yay.Id + " " + "Age= " + yay.Age + " " + "Name= " + yay.Name + " " + "Gender= " + yay.GenderId);
            }
        }

        public static void TakeLINQ()
        {
            Console.WriteLine("Take LINQ");
            var TakeAge = PeopleList.people;
            var res = TakeAge.Take(16);

            foreach (var aia in res)
            {
                Console.WriteLine("id=" + aia.Id + " " + "Age= " + aia.Age + " " + "Name= " + aia.Name + " " + "Gender= " + aia.GenderId);
            }
        }
        

        public static void SkipWhileLINQ()
        {
            Console.WriteLine("SkipWhile LINQ");

            var SkipWhileAge = PeopleList.people;
            var output = SkipWhileAge.SkipWhile(x => x.Age < 5);

            foreach (var e in output)
            {
                Console.WriteLine("id=" + e.Id + " " + "Age= " + e.Age + " " + "Name= " + e.Name + " " + "Gender= " + e.GenderId);
            }

        }

        public static void TakeWhileLINQ()
        {
            Console.WriteLine("TakeWhile LINQ");

            var TakeWhileAge = PeopleList.people;
            var outputs = TakeWhileAge.TakeWhile(x => x.Age < 8);

            foreach (var o in outputs)
            {
                Console.WriteLine("id=" + o.Id + " " + "Age= " + o.Age + " " + "Name= " + o.Name + " " + "Gender= " + o.GenderId);
            }
        }

        public static void FistLINQ()
        {
            Console.WriteLine("First LINQ");

            var FirstAge = PeopleList.people;
            var humans = FirstAge.First();

            Console.WriteLine("esimene listis: " + humans);
        }

        public static void FirstOrDefaultLINQ()
        {
            Console.WriteLine(" First Or Default LINQ");

            var FirstAge = PeopleList.people;
            var humanss = FirstAge.First();

            Console.WriteLine( humanss);
        }


    }
}