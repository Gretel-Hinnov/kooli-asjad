using Microsoft.VisualBasic;
using System.Net.Cache;

namespace LINQ_yeah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjujta number:");
            Console.WriteLine("1 - average LINQ");
            Console.WriteLine("2 - count LINQ");
            Console.WriteLine("3 - sum LINQ");
            Console.WriteLine("4 - max LINQ");
            Console.WriteLine("5 - aggregate LINQ");
            Console.WriteLine("6 - minimum LINQ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AverageLINQ();
                    break;

                case 2:
                    CountLINQ();
                    break;

                case 3:
                    SumLINQ();
                    break;

                case 4:
                    MaxLINQ();
                    break;

                case 5:
                    AggregateLINQ();
                    break;

                case 6:
                    MinLINQ();
                    break;

                default:
                    Console.WriteLine("valikut ei tehtud");
                    break;

            }

        }

        public static void AverageLINQ()
        {
            Console.WriteLine("Average LINQ");

            var averageResult = PeopleList.people
                .Average(x => x.Age);

            Console.WriteLine(averageResult.ToString("F2"));
        }

        public static void CountLINQ()
        {
            Console.WriteLine("Count LINQ");

            var totalAge = (from s in PeopleList.people
                            select s.Age).Count();

            Console.WriteLine(totalAge.ToString("F2"));
        }

        public static void SumLINQ()
        {
            Console.WriteLine("Summary LINQ");

            var res = PeopleList.people
                    .Sum(x => x.Age); 
            Console.WriteLine(res.ToString("F2"));



            var sumAdults = 0;
            var s = PeopleList.people
            .Sum(x => 
            {
                if (x.Age >= 18)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });
            Console.WriteLine("Täiskasvanute isikute koondvanus: " + s);
        }

        public static void MaxLINQ()
        {
            Console.WriteLine("Max LINQ");

            var MaxAge = (from x in PeopleList.people
                            select x.Age).Max();

            Console.WriteLine("Kõrgeim vanus = " +  MaxAge);
        }

        public static void AggregateLINQ()

  
        {
            string commaSeperatedPersonNames = PeopleList.people
                .Aggregate<People, string>(
                "People names: ",
                (str,y) => str += y.Name + ", "
                );
            Console.WriteLine(commaSeperatedPersonNames);
        }
        public static void MinLINQ()
        {
            Console.WriteLine("Min LINQ");

            var MinAge = (from x in PeopleList.people
                          select x.Age).Min();

            Console.WriteLine("Madalam vanus = " + MinAge);
        }
    }
}