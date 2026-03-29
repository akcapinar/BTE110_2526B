namespace Hafta6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int a, b, c;

            int a = 5;

            int b;

            b = 6;

            int c;

            c =  a + b;

            int d;

            d = 10;

            Console.WriteLine(d);

            d = 9;

            Console.WriteLine(d);

            const int e = 7;

            //e = 8; // This will cause a compile-time error because 'e' is a constant and cannot be assigned a new value.

            Console.WriteLine(e);

            const int f = 9; // This will cause a compile-time error because a constant must be initialized at the time of declaration.

            //f = 1;


            int g = 10;

            //int g = 20; // This will cause a compile-time error because 'g' is already declared in the same scope.

            //int h = 11;

            {
                int h = 15; // This variable 'h' is only accessible within this block.
                Console.WriteLine(h);
                Console.WriteLine(g);
            }
            {
                int h = 16; // This variable 'h' is only accessible within this block.
                Console.WriteLine(h);
            }

            sbyte i = 127; // sbyte can hold values from -128 to 127
            byte j = 255; // byte can hold values from 0 to 255
            int k = 32767; // int can hold values from -2,147,483,648 to 2,147,483,647
            short s = 32767; // short can hold values from -32,768 to 32,767
            long l = 9223372036854775807; // long can hold values from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            uint u = 4294967295; // uint can hold values from 0 to 4,294,967,295
            ushort v = 65535; // ushort can hold values from 0 to 65,535
            ulong ul = 18446744073709551615; // ulong can hold values from 0 to 18,446,744,073,709,551,615

            byte x = 255;

            double y1 = 3.14;
            double y2 = 3.14d;
            double y3 = 3.14D;

            int ŞĞÖÇIÜ = 0;

            int sayi1 = 5;
            int sayi2 = 6;
            int toplam = sayi1 + sayi2;
            int carpim = sayi1 * sayi2;
            int bolum = sayi1 / sayi2;

            int SAYI1 = 5;
            string adSoyad = "Ahmet";
            //int !asdasd = 10; // This will cause a compile-time error because variable names cannot start with an exclamation mark.
            //int asb! = 10; // This will cause a compile-time error because variable names cannot end with an exclamation mark.

            //int abc-d = 1; // This will cause a compile-time error because variable names cannot contain hyphens.

            int _abc = 10; // This is valid, variable names can start with an underscore.

            double d1 = 3.14;
            double d2 = 3.14D;
            double d3 = 3.14d;

            float f1 = 3.14f;
            float f2 = 3.14F;

            decimal dec1 = 3.14m;
            decimal dec2 = 3.14M;

            Console.WriteLine(d1);


            bool isTrue = true;
            bool isFalse = false;

            char c1 = 'a'; //"a"
            char c2 = 'A'; //"A"

            //Reference type example
            string ad = "Ahmet";
            string soyad = "Yılmaz";

            Console.WriteLine("Ad: ad");
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine($"Ad: {ad}");
            Console.WriteLine("Ad: {0}", ad);


            Console.WriteLine("Ad: ad soyad");
            Console.WriteLine("Ad: " + ad + " Soyad: " + soyad);
            Console.WriteLine($"Ad: {ad} Soyad {soyad}");
            Console.WriteLine("Ad: {1} Soyad: {1}", ad, soyad);

            //Escape sequences
            // \n: New line
            // \t: Tab
            // \\: Backslash
            // \": Double quote
            // \': Single quote
            // \r: Carriage return
            // \b: Backspace
            // \f: Form feed
            // \v: Vertical tab
            // \0: Null character
            
            Console.WriteLine("Ad: \nSoyad:");
            Console.WriteLine("Ad: \tSoyad:");
            Console.WriteLine("\"");


            string soyad1 = Console.ReadLine();
            int okunanKarakter = Console.Read();
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            Console.WriteLine(Console.ReadLine());

            

            //Değişken kapsamı (variable scope) örneği
            //Değişken türleri referans türleri ve değer türleri olarak ikiye ayrılır. Değer türleri stack'te saklanırken, referans türleri heap'te saklanır. Değer türleri doğrudan değeri tutarken, referans türleri bir bellek adresi tutar.
            //Değişken isimlendirme kuralları:
            //1. Değişken isimleri harf, rakam ve alt çizgi (_) içerebilir, ancak rakamla başlayamaz.
            //2. Değişken isimleri C# anahtar kelimeleri ile aynı olamaz.
            //3. Değişken isimleri büyük/küçük harfe duyarlıdır.
            //4. Değişken isimleri anlamlı ve açıklayıcı olmalıdır.
            //5. Değişken isimleri genellikle camelCase veya PascalCase formatında yazılır.
            //Değişken kapsamı (variable scope) örneği
            //Değişkenler, tanımlandıkları blok içinde geçerlidir. Bir değişkenin kapsamı, tanımlandığı blokla sınırlıdır. Örneğin, bir değişken bir metodun içinde tanımlanırsa, o değişken sadece o metodun içinde geçerlidir ve diğer metodlarda erişilemez.




            Console.ReadLine();
        }
    }
}
