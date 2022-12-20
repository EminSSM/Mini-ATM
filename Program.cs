using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAtm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 2500;
            Console.WriteLine("QNB FİNANSBANK'a HOŞGELDİNİZ");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Bakiye mitarınız:" + bakiye);
            }
            else if (secim == "2")
            {

                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int cekilecektutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecektutar <= bakiye)
                {
                    Console.WriteLine("Kalan bakiyeniz:" + (bakiye - cekilecektutar));
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                }


            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                int yatırılacaktutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz:" + (bakiye + yatırılacaktutar));
            }
            else if (secim == "q")
            {
                Console.WriteLine("Çıkış Yaptınız");
                Console.WriteLine("HOŞÇAKALIN...");
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız.");
            }

        }
    }
}
