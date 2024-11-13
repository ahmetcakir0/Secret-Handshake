using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Handshake
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Bir sayı girin:");

            try
            {
                int elSikismaDegeri = Convert.ToInt32(Console.ReadLine());

                List<string> hareketler = new List<string>();

                if ((elSikismaDegeri & 1) == 1) hareketler.Add("wink");
                if ((elSikismaDegeri & 2) == 2) hareketler.Add("double blink");
                if ((elSikismaDegeri & 4) == 4) hareketler.Add("close your eyes");
                if ((elSikismaDegeri & 8) == 8) hareketler.Add("jump");

                if ((elSikismaDegeri & 16) == 16) hareketler.Reverse();

                if (hareketler.Count == 0)
                {
                    Console.WriteLine("Geçerli bir el sıkışma hareketi yok.");
                }
                else
                {
                    Console.WriteLine("El sıkışma hareketleri:");
                    foreach (string hareket in hareketler)
                    {
                        Console.WriteLine(hareket);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçerli bir sayı girmediniz.");
            }
            Console.ReadLine();
        }
    }
}
