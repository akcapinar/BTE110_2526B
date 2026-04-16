namespace Hafta9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("K. Adını gir: ");
            string kAdi = Console.ReadLine();

            Console.Write("Şifre: ");
            string sifre = Console.ReadLine();

            if (kAdi == "admin" || sifre == "1234")
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Giriş başarısız");
            }
    
            Console.ReadLine();


        }

        static void Main1(string[] args)
        {
            byte notSayi;

            while (true)
            {
                notSayi = 0;
                Console.Clear();

                Console.Write("Notu gir (0-100): ");
                string notMetin = Console.ReadLine();

                notSayi = Convert.ToByte(notMetin);

                Console.WriteLine();
                Console.Write("Notunuzun harf karşılığı: ");

                if (notSayi >= 95)
                {
                    Console.Write("A1");
                }
                else if (notSayi >= 90)
                {
                    Console.Write("A2");
                }
                else if (notSayi >= 85)
                {
                    Console.Write("A3");
                }
                else if (notSayi >= 80)
                {
                    Console.Write("B1");
                }
                else if (notSayi >= 75)
                {
                    Console.Write("B2");
                }
                else if (notSayi >= 70)
                {
                    Console.Write("B3");
                }
                else if (notSayi >= 65)
                {
                    Console.Write("C1");
                }
                else if (notSayi >= 60)
                {
                    Console.Write("C2");
                }
                else if (notSayi >= 55)
                {
                    Console.Write("C3");
                }
                else if (notSayi >= 50)
                {
                    Console.Write("D");
                }
                else
                {
                    Console.Write("F3");
                }

                Console.ReadLine();
            }


            //if (not >= 95)
            //{
            //    Console.Write("A1");
            //}
            //else
            //{
            //    if (not >= 90)
            //    {
            //        Console.Write("A2");
            //    }
            //    else
            //    {
            //        if (true)
            //        {

            //        }
            //    }
            //}



            //if (not >= 85)
            //{
            //    Console.Write("A3");
            //}
            //else if (not >= 90)
            //{
            //    Console.Write("A2");
            //}
            //else if (not >= 95)
            //{
            //    Console.Write("A1");
            //}
            //else
            //{
            //    Console.Write("Başarısız");
            //}


        }
    }
}
