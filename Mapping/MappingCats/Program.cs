using AutoMapper;

namespace Mapping_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":3");

            Cat cats = new Cat();

            cats.Id = 1;
            cats.Name = "Button";
            cats.Title = "House cat";
            cats.Description = "Super cute";

            Console.WriteLine(cats.Id + " " + cats.Name + " " + cats.Title + " " + cats.Description);

            Kitty kitties = new Kitty();

            kitties.Id = 2;
            kitties.Name = "Butterscotch";
            kitties.Title = "Show cat";
            kitties.Description = "Very elegant";


            Console.WriteLine(kitties.Id + " " + kitties.Name + " " + kitties.Title + " " + kitties.Description);
            Cat cat = new Cat
            {
                Id = 3,
                Name = "Boo",
                Description = "Black cat",
                Title = "Can only see his eyes",
            };
            var mapper = Program.InitializeAutoMapper();
            var kitties2 = mapper.Map<Cat, Kitty>(cats);
            Console.WriteLine(kitties2.Id + " " + kitties2.Name + " " + kitties2.Title + " " + kitties2.Description);
        }

        public static Mapper InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cat, Kitty>();
            });

            var mapper = new Mapper(config);

            return mapper;
        }

    }

    }


public class Cat
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

}

public class Kitty
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}

