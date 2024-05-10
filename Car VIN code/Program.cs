using System.Drawing;
using System.Reflection.PortableExecutable;

namespace InheritanceVINCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta masina VIN kood: ");
            int VIN = Convert.ToInt32(Console.ReadLine());

            Machine machine = new Machine();
            machine.Cars(VIN);
            Console.WriteLine("edukalt sisestatud " + machine.CarCode());
        }
    }
    class Car
    {
        public void Cars(int v)
        {
            vin = v;
        }
        protected int vin;
    }
    class Machine : Car
    {
        public int CarCode()
        {
            return vin;
        }
    }
}

