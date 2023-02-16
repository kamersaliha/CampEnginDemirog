namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "c#";
            string kurs2 = "java";
            string kurs3 = "python";

            //arrays
            string[] kurslar = new string[] {"c#", "java", "python" };
            

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}