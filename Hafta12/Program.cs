namespace Hafta12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[10];
            int[] notlar = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin Adı:");
                isimler[i] = Console.ReadLine();
                
                Console.Write($"{i + 1}. Öğrencinin Notu:");
                notlar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("=======================");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}. Öğrenci: {isimler[i]}, Not: {notlar[i]}");
            }
        }
    }
}
