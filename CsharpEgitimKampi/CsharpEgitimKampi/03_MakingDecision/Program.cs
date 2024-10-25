using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else

            //Console.Write("Lütfen şifreyi giriniz");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz : ");
            //capital = Console.ReadLine();

            //Console.Write("ülkeyi giriniz : ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}

            //int number;
            //Console.Write("sayıyı giriniz : ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5) 
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "hata";

            //Console.Write("sınav1 : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("sınav2 : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("sınav3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("sınavların ortalaması : " + average);

            //if ( average > 0 & average <= 50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç orta";
            //}
            //if (average > 84)
            //{
            //    result = "sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("lütfen şehir girişi yapınız");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("lütfen kullanıcı adını giriniz : ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //else
            //    Console.WriteLine("hoş geldiniz");

            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("lütfen sayıyı giriniz : ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.Write("sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("sayı tektir");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.Write("galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            Console.WriteLine("****** C^Eğitim Kampı Restoran ******");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("-------------------------------");

            string menuItem;

            Console.Write("Detaylarını görmek istediğiniz menü seçimi: ");
            menuItem = Console.ReadLine();

            if(menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("----------Ana Yemekler----------");
                Console.WriteLine();
                Console.WriteLine("1-Köri Soslu Tavuk");
                Console.WriteLine("2-Kızartma Tabağı");
                Console.WriteLine("3-Fasulye Pilav");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine("----------Ana Yemekler----------");
            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("----------Çorbalar----------");
                Console.WriteLine();
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Ezogelin Çorba");
                Console.WriteLine("----------Çorbalar----------");
            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("----------Pizzalar----------");
                Console.WriteLine();
                Console.WriteLine("1-Akdeniz Pizza");
                Console.WriteLine("2-Margaritha");
                Console.WriteLine("3-Tavuklu Pizza");
                Console.WriteLine("----------Pizzalar----------");
            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("----------İçecekler----------");
                Console.WriteLine();
                Console.WriteLine("1-Kola");
                Console.WriteLine("2-Ayran");
                Console.WriteLine("3-Su");
                Console.WriteLine("----------İçecekler----------");
            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("----------Tatlılar----------");
                Console.WriteLine();
                Console.WriteLine("1-Trileçe");
                Console.WriteLine("2-Kazandibi");
                Console.WriteLine("3-Sütlaç");
                Console.WriteLine("----------Tatlılar----------");
            }

            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //	case 1:
            //		Console.Write("Ocak");
            //		break;

            //	case 2:
            //		Console.Write("Şubat");
            //		break;

            //	case 3:
            //		Console.Write("Mart");
            //		break;

            //	case 4:
            //		Console.Write("Nisan");
            //		break;
            //	case 5:
            //		Console.Write("Mayıs");
            //		break;
            //	case 6:
            //		Console.Write("Haziran");
            //		break;
            //	case 7:
            //		Console.Write("Temmuz");
            //		break;
            //	case 8:
            //		Console.Write("Ağustos");
            //		break;
            //	case 9:
            //		Console.Write("Eylül");
            //		break;
            //	case 10:
            //		Console.Write("Ekim");
            //		break;
            //	case 11:
            //		Console.Write("Kasım");
            //		break;
            //	case 12:
            //		Console.Write("Aralık");
            //		break;

            //	default:
            //		Console.Write("Hatalı veri girişi");
            //		break;
            //}


            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("Birinci sayiyi giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayiyi giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi seçin: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
            }

            #endregion

            Console.Read();
        }
    }
}
