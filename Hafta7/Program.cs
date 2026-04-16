namespace Hafta7
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Örtük Dönüşüm (Implicit Conversion)
            byte a = 123;
            int b = a;
            double e = a;



            //Açık Dönüşüm (Explicit Conversion)
            int c = 1234;
            byte d = (byte)c;
            double f = 123.999;
            byte g = (byte)f; //Veri kaybı olur


            //Convert Sınıfı
            //Parse
            //TryParse
            //ToString

            //byte x = Convert.ToByte(c); //Overflow (Taşma) exception
            //byte y = Convert.ToByte(f); //Overflow (Taşma) exception

            //ToString

            string str = c.ToString();

            str = Convert.ToString(c);

            string v = "abc";

            //byte k = Convert.ToByte(v);

            //byte l = byte.Parse(v);

            //byte m;

            //bool r = byte.TryParse(v, out m);

            //char aa = 'ʤ';
            char aa = 'A';

            int bb = aa;
            
            byte cc = (byte)aa;

            byte dd = Convert.ToByte(bb);

            int ff = 12345678;
            char gg = (char)ff;
            char hh = Convert.ToChar(ff);

        }

        static void Main(string[] args)
        {
            //Console.Write("1. Sayı giriniz:");
            //string say1 = Console.ReadLine();

            //Console.Write("2. Sayı giriniz:");
            //string say2 = Console.ReadLine();

            //Console.WriteLine($"Toplam: {byte.Parse(say1) + byte.Parse(say2)}");

            int a = 9;
            a = a + 1;
            a += 1;

            a = a - 1;
            a -= 1;

            a = a * 2;
            a *= 2;

            a = a / 2;
            a /= 2;

            a %= 2;
            a = a % 2;

            int b = 1;
            b++; //b = b + 1; //b += 1;
            ++b;
            b--; //b = b - 1; //b -= 1;
            --b;

            int c = 1;
            int d = ++c;
            Console.WriteLine(c); // Post-increment: c is printed first, then incremented 
            Console.WriteLine(d);

            int e = 1;
            e = ++e;

            Console.WriteLine(e);

            //Mantıksal İşlemler
            //==, !=, >, <, >=, <= //true false dönerler

            bool aa = 1 == 1;
            bool bb = 1 != 1;
            bool cc = 1 > 1;
            bool dd = 1 < 1;
            bool ff = 1 >= 1;
            bool hh = 1 <= 1;

            bool gg = "abc" == "abc";


            int nn = (1 + 2) * 3 + 1 / 1; // 1 + (2 * 3) = 1 + 6 = 7

            //or and işlemleri
            //||, &&

            bool mm = 1 < 2 || (1 < 3 && 2 == 2);
            bool oo = true || (false && false);

            string kad = "abc";
            string sifre = "123";

            bool login1 = kad == "abc" && sifre == "456";
            bool login2 = kad == "abc" || sifre == "456";

            bool yy = true;

            yy = !yy; // yy = false

            Console.WriteLine(!yy == false);
            Console.WriteLine(yy);


            double say1 = 5.6;
            int say2 = 5;


            double sonuc = say2 / say1;

            Console.ReadLine();
        }
    }
}
