using LINQ.Models;

namespace LINQ
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>()
        {
            new People()
            {
                Id = 1,
                Name = "Moona",
                Age = 31,
                GenderId = Guid.Parse("d2702fa1-a23d-426c-bd99-bac87caa403f")
            },

            new People()
            {
                Id = 2,
                Name = "Poona",
                Age = 21,
                GenderId = Guid.Parse("d2702fa1-a23d-426c-bd99-bac87caa403f")
            },

            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("ff4ced43-5823-479a-af05-35d21726e995")
            },

            new People()
            {
                Id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("d2702fa1-a23d-426c-bd99-bac87caa403f")
            },

            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("d2702fa1-a23d-426c-bd99-bac87caa403f")
            },
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 21,
                GenderId = Guid.Parse("d2702fa1-a23d-426c-bd99-bac87caa403f")
            },

            new People()
            {
                Id = 7,
                Name = "Bill",
                Age = 21,
                GenderId = Guid.Parse("ff4ced43-5823-479a-af05-35d21726e995")
            }

        };
    }
}
