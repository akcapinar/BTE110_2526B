namespace Hafta9Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.CursorLeft = 0;
                Console.CursorTop = 5;

                Console.Write("1-Şifrele               ");

                Console.CursorLeft = 0;
                Console.CursorTop = 6;

                Console.Write("2-Şifreyi Çöz           ");

                Console.CursorLeft = 0;
                Console.CursorTop = 7;


                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("3-Çıkış                 ");

                Console.ResetColor();

                Console.CursorTop = 9;
                Console.CursorLeft = 0;

                Console.Write("Seçiminiz: ");
                
                ConsoleKeyInfo secim = Console.ReadKey();

                Console.Clear();

                if (secim.Key == ConsoleKey.D1)
                {
                    Console.Write("Şifrelenecek metini giriniz: ");
                    string sifrelenecekMetin = Console.ReadLine();

                    string sifrelenmisMetin = "";

                    for (int i = 0; i < sifrelenecekMetin.Length; i++)
                    {
                        sifrelenmisMetin += (char)(((int)sifrelenecekMetin[i]) + 7);
                    }

                    Console.WriteLine("-------------------------");
                    Console.WriteLine($"Şifrelenecek metin: {sifrelenecekMetin}");
                    Console.WriteLine($"Şifrelenmiş metin: {sifrelenmisMetin}");

                    Console.WriteLine();
                    Console.Write("Menüye dönmek için bir tuşa basın...");
                    Console.ReadKey();
                }
                else if (secim.Key == ConsoleKey.D2)
                {
                    Console.Write("Şifrelenmiş metini giriniz: ");
                    string sifrelenmisMetin = Console.ReadLine();

                    string sifresizMetin = "";

                    for (int i = 0; i < sifrelenmisMetin.Length; i++)
                    {
                        sifresizMetin += (char)(((int)sifrelenmisMetin[i]) - 7);
                    }

                    Console.WriteLine("-------------------------");
                    Console.WriteLine($"Şifrelenmiş metin: {sifrelenmisMetin}");
                    Console.WriteLine($"Şifresiz metin: {sifresizMetin}");
                    

                    Console.WriteLine();
                    Console.Write("Menüye dönmek için bir tuşa basın...");
                    Console.ReadKey();
                }
                else if (secim.Key == ConsoleKey.D3)
                {
                    Console.Write("GÜLE GÜLE....");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                }
            }

            
        }
    }
}
