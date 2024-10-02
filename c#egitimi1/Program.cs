using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_egitimi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.Write("Hello world");
            //Console.Write("Rümeysa Yılmaz");
            //Console.WriteLine("C# Eğitimi");
            //Console.Read();

            //Console.WriteLine("****YEMEK KATEGORİLERİ****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***YEMEK KATEGORİLERİ****");
            #endregion
            #region String Değişkenler
            //string name;
            //name = "Rümeysa";
            //Console.Write(name);
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district,city;
            //customerName = "Rümeysa";
            //customerSurname = "Yılmaz";
            //customerPhone = "0507 412 8226";
            //customerEmail = "hwehren@gmail.com";
            //district = "seyhan";
            //city = "adana";
            //Console.WriteLine("***Rezervasyon Kartı***");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri:" + customerName +" "+ customerSurname);
            //Console.WriteLine("İletişim" +customerPhone);
            //Console.WriteLine("Email Adresi"+customerEmail);
            //Console.WriteLine("Adres:"+district +"/"+ city);
            //Console.WriteLine("----------------------------");
            //customerName = "Neva";
            //customerSurname = "Yılmaz";
            //customerPhone = "0507 890 8226";
            //customerEmail = "webfıen@gmail.com";
            //district = "sarıçam";
            //city = "adana";
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim" + customerPhone);
            //Console.WriteLine("Email Adresi" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("----------------------------");
            #endregion
            #region Int Değişkenler
            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerprice = 300;
            int cokeprice = 35;
            int waterprice = 10;
            int friesprice = 50;
            int pizzaprice = 250;
            int lemonadeprice = 30;
            Console.WriteLine("****Restoran Menü Fiyatı****");
            Console.WriteLine();
            Console.WriteLine("---Hamburger Fiyatı:"+ hamburgerprice+"tl");
            Console.WriteLine("---Kola Fiyatı:"+ cokeprice+"tl");
            Console.WriteLine("---Su Fiyatı:"+ waterprice+"tl");
            Console.WriteLine("---Kızartma Fiyatı:"+ friesprice+"tl");
            Console.WriteLine("---Pizza Fiyatı:"+ pizzaprice+"tl");
            Console.WriteLine("---Limonata Fiyatı:"+ lemonadeprice+"tl");
            Console.WriteLine();
            Console.WriteLine("Restoran Menü Fiyatı");
            Console.WriteLine();
            int hamburgercount;
            int cokecount;
         int watercount;
            int friesprcount;
            int pizzcount;
            int lemonadecount;
            int totalhamburgerprice=0 ;
            int totalcokeprice;
            int totalwaterprice;
            int totalfriesprice;
            int totalpizzaprice;
            int totallemonadeprice;
            hamburgercount = 10;
            cokecount = 5;
            watercount = 10;
            friesprcount = 5;
            pizzcount = 8;
            lemonadecount = 8;
            totalhamburgerprice = hamburgercount * hamburgerprice;
            totalcokeprice = cokecount * cokecount;
            totalwaterprice = watercount * watercount;
             totalpizzaprice = pizzcount * pizzcount;
            totallemonadeprice = lemonadecount * lemonadeprice;
            Console.WriteLine("---------------");
            Console.WriteLine("Toplam Hamburger Tutarı:"+totalhamburgerprice+"tl");
            Console.WriteLine("Toplam kola Tutarı:"+totalcokeprice+"tl");
            Console.WriteLine("Toplam su Tutarı:"+totalwaterprice+"tl");
            Console.WriteLine("Toplam pizza Tutarı:"+totalpizzaprice+"tl");
            Console.WriteLine("Toplam limonata Tutarı:"+totallemonadeprice+"tl");
            Console.WriteLine();

            int totalprice=totalhamburgerprice+totalcokeprice+totalwaterprice+totalpizzaprice+totallemonadeprice;
            Console.WriteLine("Toplam ödenecek tutar:"+totalprice+"Tl");
           
            
            #endregion




        }
    }
}
