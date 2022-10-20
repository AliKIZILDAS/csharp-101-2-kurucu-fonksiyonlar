using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //söz dizilimi
            // Class SınifAdi
            // {
            //      [erişim Belirleyici] [Veri Tipi] Özellikadi;
            //      [erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([parametre listesi]);
            //      {
            //      Metot Komutları
            //      }
            // }
            // Erişim belirleyiciler
            //*Public Her yerden erişilebilir.
            //*Private Sadece tanımlandığı sınıf içerisinden erişilebilir.
            //*Protected  Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir
            //*Interval Sadece bulunduğu proje içerisinden erişilebilir
            Calisan calisan1=new Calisan("Ayşe","Kara",2235634,"İnsan Kaynakları");
            
            calisan1.CalisanBilgileri();
            Console.WriteLine("**********");

            Calisan calisan2=new Calisan("Deniz","Arda",25646789,"Satın Alma");
            

            calisan2.CalisanBilgileri();
            Console.WriteLine("*****Çalışan 3*****");

            Calisan calisan3=new Calisan("Zikriye","Ürkmez");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no,string departman)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }
        public Calisan(){}
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}" , Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}" , Soyad);
            Console.WriteLine("Çalışanın No: {0}" , No);
            Console.WriteLine("Çalışanın Departmanı: {0}" , Departman);
        }
    }
}
   