using AutoMapper;
using System.Reflection.Metadata.Ecma335;


namespace Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapper");

            Employee emp = new Employee();

            emp.Id = 11;
            emp.Name ="Name";
            emp.Title ="Title";
            emp.Description ="Description";

            EmployeeDto dto = new EmployeeDto();
            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Title = emp.Title;
            dto.Description = emp.Description;

            Console.WriteLine(dto.Id + " " + dto.Name + " " + dto.Title + " " + dto.Description);
            Console.WriteLine("-------------------------Nüüd algab Automapper------------------");
            Employee employee = new Employee
            {
                Id = 123,
                Name = "Name123",
                Description = "desc123",
                Title = "Title123",
            };

            var mapper = Program.InitializeAutoMapper();
            var empDto2 = mapper.Map<Employee, EmployeeDto>(employee);
            Console.WriteLine(empDto2.Id + " " + empDto2.Name + " " + empDto2.Title + " " + empDto2.Description);
        }

        public static Mapper InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDto>();
            });

            var mapper = new Mapper(config);

            return mapper;
        }
        //Kasutatakse keeruliste andmestruktuuride, sagedaste vastenduste
        //ja suurte töörühmadega tegelemisel kaardistajaid,
        //nagu AutoMapperit, et tagada järjepidevus ja vähendada standardkoodi.
        //C#-i kaardistajad(Mapper) on teegid või tööriistad, mis
        //töötlevad automaatselt andmeid ühelt objektilt teisele. 
    }


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }

    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
