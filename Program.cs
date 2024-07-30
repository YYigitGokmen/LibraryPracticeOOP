
using PatikaLibraryPractice;

public class Program
{
    public static void Main(string[] args)
    {

        //Bir tanesi default constructor tarzında parmetre almadan çalışan bir metot.
        bookRecord ctor = new bookRecord();
        //new ile sınıftan bir obje yaratırız ve bu sayede sıfın özellikerini kullanabilriiz
        //Constructor ise adındanda anlaşılabileceği gibi YAPICI bir metotdur 
        //bu metotdu çağırdığımızda belli başlı şeyleri yapmamız gerekir.
        //metot overriding özelliği ile farklı ctorlar üretilebilir.


        Console.WriteLine("");

        //Diğeri Kitap adı, Yazar Adı, Sayfa Sayısı, Yayınevi  bilgilerini alıp bu değerleri nesne üretim aşamasında atayan bir metot.
        bookRecord ctor2 = new bookRecord("Aşkı-Memnu","Halit Ziya","Uşaklıgil",450,"penguen");

        Console.WriteLine("");

        bookRecord ctor3 = new bookRecord("Çalıkuşu", "Reşat Nuri", "Güntekin", 300, "seri");



    }


}
