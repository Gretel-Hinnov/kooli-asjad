namespace FileReaderAndWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            FileReaderAndWriter();
        }


        static void FileReaderAndWriter()
        {
            string line; 
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/tuttavad.txt"))
                {

                    string rida = sr.ReadToEnd();
                        string[] nimed = rida.Split('\n');

                        Array.Sort(nimed);

                        foreach (var nimi in nimed)
                        {
                        Console.WriteLine(nimi);
                        }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Faili ei saa lugeda");
                Console.WriteLine(e.Message);
                throw;
            }

            using (StreamWriter sr = new StreamWriter("C:/Users/opilane/Desktop/tuttavad.txt"))
            {

            }
                

        }

    }
}