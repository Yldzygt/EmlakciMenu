using System;
using System.Collections.Generic;

namespace Ev
{
    public class SatilikEv
    {
      private  byte OdaSayisi;
       private int Alan;
        private String Binaİsmi;
        private byte KatNo;
         private int Fiyat;

       String Cevap ;
   
        public void KullanıcıdanDegerAl()
        {

            for (int i = 0; i < 1; i++) //Döngünün dönme sayısı girilen evler generic koleksiyona atılıp sayısı kadar olucak.
            {
                Console.WriteLine("Oda Sayısı Giriniz");
                byte OdaSayisi = byte.Parse(Console.ReadLine());

                Console.WriteLine("Alan Giriniz");
                byte Alan = byte.Parse(Console.ReadLine());


                Console.WriteLine("Bina İsmi Giriniz");
                Binaİsmi = Console.ReadLine();


                Console.WriteLine("Kat Numarası Giriniz");
                byte KatNo = byte.Parse(Console.ReadLine());


                Console.WriteLine("Fiyat Giriniz");
                byte Fiyat = byte.Parse(Console.ReadLine());

                Console.WriteLine("Tamam/Devam Seçeneklerinden Birini Seçiniz :)");

                if (Cevap == "Tamam") { Console.WriteLine("Bilgileriniz Dosyaya Başarılı Bir Şekilde Kaydedildi.");  break; }
               
                else if (Cevap == "Devam") { } //Döngüye tekrarlıcak:

                else { Console.WriteLine("Hatalı Tuşlama Yaptınız..."); };

            }
        }

        

       


        
    }
}
