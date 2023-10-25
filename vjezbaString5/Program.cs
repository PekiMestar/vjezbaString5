using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaString5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst;

            Console.WriteLine("Upišite jedan cijeli broj i jedan decimalan broj sa razmakom između njih.");

            tekst = Console.ReadLine();

            string[] brojevi = tekst.Split(' ');

            int.TryParse(brojevi[0], out int BrojC);

            double.TryParse(brojevi[1], out double BrojD);

            Console.WriteLine(BrojC*2);   

            Console.WriteLine(BrojD*2);  

            Console.ReadKey();

        }
    }
}
