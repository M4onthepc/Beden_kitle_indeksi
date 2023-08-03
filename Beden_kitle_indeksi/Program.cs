using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beden_kitle_indeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baslik = "Beden kitle endeksi programı başlatıldı. Lütfen aşşağıda istenen bilgileri giriniz .\n";
            Console.WriteLine(baslik);

            Console.Write("Boy ( cm cinsinden , ile ayırarak giriniz ): ");
            double boy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kilo : ");
            int kg = Convert.ToInt32(Console.ReadLine());

            double indeks = kg / (boy * boy);

            if (indeks <= 18)
            {
                Console.Write(indeks + "\nVücut Kitle İndeksiniz : Zayıf");
            }
            else if (indeks > 18 && indeks <= 25)
            {
                Console.Write(indeks + "\nVücut Kitle İndeksiniz : Normal");
            }
            else
            {
                Console.Write(indeks + "\nVücut Kitle İndeksiniz : Obez");
            }
            Console.Read();
        }
    }
}
