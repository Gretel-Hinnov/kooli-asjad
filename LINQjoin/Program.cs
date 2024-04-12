namespace LINQjoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JoinLINQ();
            GroupJoin();
        }
        public static void JoinLINQ()
        {
            var innerJoin = PeopleList.people
                .Join
            ( 
               GenderList.genderList,
               humans=> humans.GenderId,
               gender => gender.Id,
               (humans, gender) => new
               {
                Name = humans.Name,
                GenderName = gender.GenderName,
               }
            );

            foreach (var p in innerJoin)
            {
                Console.WriteLine("{0} - {1}", p.Name, p.GenderName);
            }
        }


        public static void GroupJoin()
        {
            var groupJoin = GenderList.genderList
                           .GroupJoin
                       (
                          PeopleList.people,
                          p=> p.Id,
                          g=> g.GenderId,
                          (p, peopleGroup) => new
                          {
                              Name = peopleGroup,
                              GenderFullName = p.GenderName,
                          }
                       );

            foreach (var t in groupJoin)
            {
                Console.WriteLine(t.GenderFullName);

                foreach (var name in t.Name)
                {
                    Console.WriteLine(name.Name);
                }
            }
        }
    }
}