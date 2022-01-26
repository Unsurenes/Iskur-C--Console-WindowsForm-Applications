using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cekilis
{
    class Program
    {
        static void Main(string[] args)
        {
            IsimListe liste = new IsimListe();

            int devam;
            do
            {

                Console.WriteLine("Çekilişe dahil etmek istediğiniz kişi sayısını giriniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < sayi; i++)
                {
                    Console.Write(i + 1 + ". kişinin ismini giriniz:");
                    string isim = Console.ReadLine();
                    liste.Ekle(i, isim);

                }
                Console.WriteLine("Çekilişi başlatmak için tıklayınız");
                Console.ReadLine();
                Console.Clear();

                Random rand = new Random();
                List<int> randomlist = new List<int>();
                for (int i = 0; i < sayi; i++)
                {
                    int c;
                    do
                    {
                        c = rand.Next(sayi);
                    } while (randomlist.Contains(c));
                    randomlist.Add(c);
                    Console.WriteLine(i + 1 + ". Talihli " + liste.isim[c]);
                    Console.ReadLine();
                }
                Console.WriteLine("Çekiliş bitmiştir.Tekrarlamak için 1 çıkmak için 2'yi tuşlayınız");
                devam = Convert.ToInt32(Console.ReadLine());
                Console.Clear();



            } while (devam == 1);
        }
    }
}
