using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmUyg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 3500;

            while (true)
            {
                Console.WriteLine("1. para çekme");
                Console.WriteLine("2. paa yatırma");
                Console.WriteLine("3. bakiye sorgulama");
                Console.WriteLine("4. çıkış");
                Console.WriteLine("seçiminizi giriniz: ");

                int secim = int.Parse(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.Write("Çekmek istedigin tutar");
                        double cekilecekTutar = double.Parse(Console.ReadLine());
                        if (cekilecekTutar > bakiye)
                        {
                            Console.WriteLine("yetersiz bakiye: ");
                        }

                        else
                        {
                            bakiye -= cekilecekTutar;
                            Console.WriteLine("para Çekme işleme başarılı.");
                        }
                        break;

                    case 2:

                        Console.Write("yatırmak istedigin tutarı girin: ");
                        double yatirilacakTutar = double.Parse(Console.ReadLine());

                        bakiye += yatirilacakTutar;
                        Console.WriteLine("para yatırma işlemi başarılı. ");
                        break;

                    case 3:
                        Console.WriteLine("bakiyeniz: " + bakiye);
                        break;

                    case 4:
                        Console.WriteLine("çıkış yapılıyor...");
                        Environment.Exit(0);

                        break;

                    default:
                        Console.WriteLine("gecersiz seçim");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
