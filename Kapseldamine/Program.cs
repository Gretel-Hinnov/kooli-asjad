using Encapsulation.Service;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kapseldamine");

            Student student = new Student();

            student.Id = 101;
            student.Name = "Test";
            student.Email = "a@a.com";

            Console.WriteLine("Id = " + student.Id);
            Console.WriteLine("Id = " + student.Name);
            Console.WriteLine("Id = " + student.Email);



            ProtectedStudent protectedStudent = new ProtectedStudent();

            //protectedStudent.DoSomething();
            //kui DoSomething on protected ja teise sklassis, siis ei saa seda kasutada.

            Console.WriteLine("---------------------------------------");
            Program program = new Program();
            program.DoSometingInProgramClass();

            Console.WriteLine("------------------Private protected---------------------");
            Program pp = new Program();
            Console.WriteLine(pp.privateProtectedInProgramClass = "privateProtectedInProgramClassMainMethod");

            var privateProtectedStudent = new PrivateProtectedStudent();

            //privateProtectedStudent.PrivateProtectedStudent1 = "ldjnvmkghnf";

            Console.WriteLine("------------------------Sealed Class-------------------------");
            var sc = new SealedStudent();
            sc.Id = 123;
            sc.Name = "Test";
            sc.Email = "a@a.com";
            Console.WriteLine($"Id on {sc.Id}, Name on {sc.Name} ja Email on {sc.Email}");

        }
        protected void DoSometingInProgramClass()
        {
            Console.WriteLine("DoSomethingInProgramClass");
        }
        private protected string privateProtectedInProgramClass = "privateProtectedInProgramClass";

    }
}
