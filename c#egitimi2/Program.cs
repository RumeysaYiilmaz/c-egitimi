using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_egitimi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.WriteLine("Fiyat Listesi");
            //Console.WriteLine();
            //double appleprice, orangeprice, strawberryprice, potatoprice, tomatoprice;
            //appleprice = 14.85;
            //orangeprice = 20.85;
            //strawberryprice = 16.86;
            //potatoprice = 9.74;
            //tomatoprice = 6.88;
            //Console.WriteLine("----Elma Birim Fiyatı:" + appleprice+"tl");
            //Console.WriteLine("---Portakal Birim Fiyatı:" + orangeprice+"tl");
            //Console.WriteLine("---Çilek Birim Fiyatı:"+strawberryprice+"tl");
            //Console.WriteLine("---Patates Birim Fiyatı:"+ potatoprice +"tl");
            //Console.WriteLine("---Domates Birim Fiyatı:"+tomatoprice+"tl");
            //Console.WriteLine();
            //double applegram, orangegram,strawgram,patatogram, tomatogram;
            //applegram = 1245;
            //orangegram = 2650;
            //strawgram = 1450;
            //patatogram = 1870;
            //tomatogram = 0.750;
            //double appletotalprice = applegram * appleprice;
            //double orangetotalprice = orangegram * orangeprice;
            //double strawberrytotalprice = strawgram * strawberryprice;
            //double patatototalprice = patatogram * potatoprice;
            //double tomatototalprice = tomatogram * tomatoprice;

            //Console.WriteLine("Alınan Ürün Elma-" + "Birim Fiyat:"+appleprice+ "Gramaj"+applegram + "Toplam Tutar:"+appletotalprice);
            //Console.WriteLine("Alınan Ürün Portakal-" + "Birim Fiyat:" + orangeprice + "Gramaj" + orangegram + "Toplam Tutar:" + appletotalprice);
            //Console.WriteLine("Alınan Ürün Çilek-" + "Birim Fiyat:" + strawberryprice + "Gramaj" + strawgram + "Toplam Tutar:" + appletotalprice);
            //Console.WriteLine("Alınan Ürün Patates-" + "Birim Fiyat:" + potatoprice + "Gramaj" + patatogram + "Toplam Tutar:" + patatototalprice);
            //Console.WriteLine("Alınan Ürün Domates-" + "Birim Fiyat:" + tomatoprice + "Gramaj" + tomatogram + "Toplam Tutar:" + tomatototalprice);

            //double shoppingtotal=appletotalprice+orangetotalprice+strawberrytotalprice+patatototalprice+tomatototalprice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar:"+shoppingtotal+"Tl");
            #endregion
            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);
            #endregion
            #region Klavyeden Veri girişleri string değişkenler
            //Console.WriteLine("---CSharp Hava YollarıYolcu Bilgisi---");
            //Console.WriteLine();
            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge,passangerIdentityNumber;
            //Console.Write("--Yolcu Adı:");
            //passangerName = Console.ReadLine();
            //Console.Write("--Yolcu Soyadı:");
            //passangerSurname = Console.ReadLine();
            //Console.Write("--İlçe Bilgisi:");
            //passangerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi:");
            //passangerCity = Console.ReadLine();
            //Console.Write("---Yolcu Yaş:");
            //passangerAge = Console.ReadLine();
            //Console.Write("--Yolcu Kimlik Numarası:");
            //passangerIdentityNumber = Console.ReadLine();
            //Console.WriteLine() ;
            //Console.WriteLine("---------------");
            //Console.WriteLine("Yolcu kimlik numarası"+" "+passangerIdentityNumber+" "+"Yolcu ad-soyad" + passangerName + " " + passangerSurname+" "+passangerDistrict+" /"+passangerCity+" "+" "+passangerAge);




            #endregion
            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler
            //int shoesprice, computerprice, chairprice, tvprice;
            //shoesprice = 1200;
            //computerprice = 20000;
            //chairprice = 2500;
            //tvprice = 1890;
            //int shoesCount,computerCount,chairCount,tvCount;
            //Console.WriteLine("--Lütfen aldığınız ayakkabı sayısını giriniz");
            //shoesCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("--Lütfen aldığınız bilgisayar sayısını giriniz");
            //computerCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız sandalye sayısını Giriniz");
            //chairCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz");
            //tvCount=int.Parse(Console.ReadLine());
            //int totalPrice=shoesCount*shoesprice+computerCount*computerprice+chairCount*chairprice+tvCount*tvprice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar:,"+totalPrice);
            //#endregion
            //#region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2,exam3,result;
            //Console.Write("Lütfen 1.sınav notunuzu giriniz");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sınav notunuzu giriniz");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.sınav notunuzu giriniz");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız"+result);
            #endregion
            #region Klavyeden Karakter Girişleri
            char gender;
            Console.WriteLine("Lütfen Cinsiyet Seçiniz");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet:"+gender);
            #endregion

            Console.Read();


           
        }
    }
}
