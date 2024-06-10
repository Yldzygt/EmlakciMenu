using System.Collections.Generic;
using System.IO;
using System.Runtime;
using System.Runtime.CompilerServices;
using EvLibb;

namespace EmlakciAnaMenu
{
    internal class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Hangi Tür Ev Görüntülemek İstiyorsunuz ?\n Satılık için 1{\nKiralık için 2 ye basınız.\n");
            byte cevap = byte.Parse(Console.ReadLine());
            if (cevap == 1)
            {
                Console.WriteLine("Satılık Ev bölümü");
                Console.WriteLine("Kayıtlı evler için 1, yeni giriş için 2 olarak giriş yapınız.");
                short cevaps = short.Parse(Console.ReadLine());
                if (cevaps == 1)
                {
                    Console.WriteLine("Kayıtlı Evler:");
                    Dosya_Oku_Satilik();
                }
                else if (cevaps == 2)
                {
                    List<string> list = new List<string>();
                    string durum;
                    do
                    {
                        SatilikEv sev = new SatilikEv();
                        Console.WriteLine("Oda Sayısı:");
                        sev.Odasayisi = byte.Parse(Console.ReadLine());
                        Console.WriteLine("Alan:");
                        sev.Alan = double.Parse(Console.ReadLine());
                        Console.WriteLine("Bina İsmi:");
                        sev.BinaIsim = Console.ReadLine();
                        Console.WriteLine("KAt No:");
                        sev.KatNo = byte.Parse(Console.ReadLine());
                        Console.WriteLine("Fiyat:");
                        sev.Fiyat = double.Parse(Console.ReadLine());
                        list.Add(sev.ToString());
                        Console.WriteLine("Yeni ev kaydı yapmaya devam etmek isityor musunuz? (evet/hayır)");
                        durum = Console.ReadLine().ToLower();
                    } while (durum != "hayır");
                    bool hata = false;
                    try
                    {
                        Dosyayaz_Satilik(list);
                    }
                    catch (Exception)
                    {
                        hata = true;
                    }
                    if (hata)
                    {
                        Console.WriteLine("Bir hata oluştu");
                    }
                    else
                    {
                        Console.WriteLine("Yeni kayıtlar başarıyla kaydedildi.");
                    }





                }
            }
            else if (cevap == 2)
            {
                Console.WriteLine("Kiralık Ev Bölümü");
                Console.WriteLine("Kayıtlı evler için 1, yeni giriş için 2 olarak giriş yapınız.");
                short cevapk = short.Parse(Console.ReadLine());
                if (cevapk == 1)
                {
                    Console.WriteLine("Kayıtlı Evler:");
                    Dosya_Oku_Kiralik();
                }
                else if (cevapk == 2)
                {
                    List<string> list = new List<string>();

                    string durumK;

                    do
                    {
                        KiralikEv sek = new KiralikEv();
                        Console.WriteLine("Oda Sayısı Giriniz:");
                        sek.Odasayisi = byte.Parse(Console.ReadLine());
                        Console.WriteLine("Alan Giriniz:");
                        sek.Alan = double.Parse(Console.ReadLine());
                        Console.WriteLine("Bina İsmi Giriniz");
                        sek.BinaIsim = Console.ReadLine();
                        Console.WriteLine("Kat No Giriniz:");
                        sek.KatNo = byte.Parse(Console.ReadLine());
                        Console.WriteLine("Kira Bedeli Giriniz");
                        sek.Kira = double.Parse(Console.ReadLine());
                        Console.WriteLine("Depozito Bedeli Giriniz:");
                        sek.Depozito = double.Parse(Console.ReadLine());
                        list.Add(sek.ToString());
                        Console.WriteLine("Yeni ev kaydı yapmaya devam etmek isityor musunuz? (evet/hayır)");
                        durumK = Console.ReadLine().ToUpper();
                    } while (durumK != "HAYIR");
                    bool hata_K = false;
                    try
                    {
                        Dosyayaz_Kiralik(list);
                    }
                    catch (Exception)
                    {
                        hata_K = true;
                    }
                    if (hata_K)
                    {
                        Console.WriteLine("Bir hata oluştu");
                    }
                    else
                    {
                        Console.WriteLine("Yeni kayıtlar başarıyla kaydedildi.");
                    }
                }
            }


        }
        public static void Dosyayaz_Kiralik(List<string> list)
        {
            string dosya_yolu = "C:\\Users\\YİĞİT\\Desktop\\C# UYGULAMA\\EmlakciAnaMenu\\EmlakciAnaMenu\\KiralikEvler.txt";
            using (StreamWriter sw = new StreamWriter(dosya_yolu))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                }
            }

        }

        public static void Dosyayaz_Satilik(List<string> list)
        {
            string dosya_yolu = "C:\\Users\\YİĞİT\\Desktop\\C# UYGULAMA\\EmlakciAnaMenu\\EmlakciAnaMenu\\SatilikEvler.txt";
            using (StreamWriter sw = new StreamWriter(dosya_yolu))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                }
            }

        }

        public static void Dosya_Oku_Kiralik()
        {
            string dosya_yolu = "C:\\Users\\YİĞİT\\Desktop\\C# UYGULAMA\\EmlakciAnaMenu\\EmlakciAnaMenu\\KiralikEvler.txt";
            using (StreamReader sr = new StreamReader(dosya_yolu))
            {
                string yazi = sr.ReadToEnd();
                if (yazi != null)
                {
                    Console.WriteLine(yazi);
                }
                else
                {
                    Console.WriteLine("Girilmiş veri bulunamadı.");
                }
            }
        }

        public static void Dosya_Oku_Satilik()
        {
            string dosya_yolu = "C:\\Users\\YİĞİT\\Desktop\\C# UYGULAMA\\EmlakciAnaMenu\\EmlakciAnaMenu\\SatilikEvler.txt";
            using (StreamReader sr = new StreamReader(dosya_yolu))
            {
                string yazi = sr.ReadToEnd();
                if (yazi != null)
                {
                    Console.WriteLine(yazi);
                }
                else
                {
                    Console.WriteLine("Girilmiş veri bulunamadı.");
                }
            }

        }
      
    }
}

