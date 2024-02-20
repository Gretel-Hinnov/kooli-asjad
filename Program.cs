namespace Kontrolltöö
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Millist kujundit soovid?\n ruut, teemant, ristkülik, kolmnurk");
            string valik = Console.ReadLine().ToLower();

            switch (valik)
            {
                case "ruut":
                    Ruut();
                    break;
                case "teemant":
                    Teemant();
                    break;
                case "ristkülik":
                    Ristkülik();
                    break;
                case "kolmnurk":
                    Kolmnurk();
                    break;
                default:
                    Console.WriteLine("Seda kujundit pole");
                    break;
            }
        }

        static void Ruut()
        {
            Console.WriteLine("Sisesta ruudu külje pikkus:");
            int külg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ruut:");
            for (int i = 0; i < külg; i++)
            {
                for (int j = 0; j < külg; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int ümbermoot = 4 * külg;
            int pindala = külg * külg;
            Console.WriteLine($"Ruudu ümbermõõt on {ümbermoot} ja pindala on {pindala} ühikut.");
        }


        static void Teemant()
        {
            Console.WriteLine("Sisesta teemanti diagonaal: ");
            int diagonaal1 = Convert.ToInt32(Console.ReadLine());


            int poolDiag1 = diagonaal1 / 2;


            Console.WriteLine("Teemant:");

            for (int i = 0; i <= diagonaal1 / 2; i++)
            {
                for (int j = 0; j <= diagonaal1 / 2 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = diagonaal1 / 2 - 1; i >= 0; i--)
            {
                for (int j = 0; j <= diagonaal1 / 2 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        static void Ristkülik()
        {
            Console.WriteLine("Sisesta ristküliku pikkus ja laius:");
            int pikkus = Convert.ToInt32(Console.ReadLine());
            int laius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ristkülik:");

            for (int i = 0; i < laius; i++)
            {
                for (int j = 0; j < pikkus; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }

        static void Kolmnurk()
        {
            Console.WriteLine("Sisesta kolmnurga alus ja kõrgus:");
            int alus = Convert.ToInt32(Console.ReadLine());
            int kõrgus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kolmnurk:");

            for (int i = 0; i < kõrgus; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
    








