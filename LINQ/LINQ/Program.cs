using LINQ.Models;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kurtsume esile LINQ läi switchi");
            Console.WriteLine("Vali vastav link numbriga");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    WhereLINQ();
                    WhereByNameLINQ();
                    break;

                default:
                    Console.WriteLine("valikut ei tehtud");
                    break;
            }


        }

        public static void WhereLINQ()
        {
            var peopleAge = PeopleList.peoples
                .Where(x => x.Age > 20 && x.Age < 23);

            foreach (var item in peopleAge)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void WhereByNameLINQ()
        {
            Console.WriteLine("Kirjuta inimese nimi: ");
            string name = Console.ReadLine();

            var peopleName = PeopleList.peoples
                .Where(x => x.Name == name);


            foreach (var people in peopleName)
            {
                Console.WriteLine(people.Name);
            }
        }
    }
}