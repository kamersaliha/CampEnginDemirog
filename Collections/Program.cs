using System.Collections.Generic;
using System.Security.Claims;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Kamer", "Sezgin" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);

            isimler = new string[3];
            isimler[2] = "İlker";
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string>();
            isimler2.Add("Ümmü");
            Console.WriteLine(isimler2[0]);

            List<string> isimler3 = new List<string> { "Ufuk", "Mustafa" };
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            isimler3.Add("Kayra");
            Console.WriteLine(isimler3[2]);
            Console.WriteLine(isimler3[0]);
        }
    }
}