namespace FileWordReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            FileWordReading();
        }

        static void FileWordReading()
        {
            string line; //sõna muutja deklareerimine
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/luuletus.txt" ))
                {
                    int cnt = 0; //rea muutuja
                    while(sr.EndOfStream == false)
                    {
                        ++cnt;//rea numbri suurendamine 1 ühiku võrra
                        line = sr.ReadLine();//teksti lugemine txt failist
                        int pikkus = line.Length;
                        Console.WriteLine(cnt + " " + line + " " + pikkus);
                    }
                    sr.Close();//faili lugemise lõpetamine
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Faili ei saa lugeda");
                Console.WriteLine(e.Message);
                throw;
            }
        }

    }
}