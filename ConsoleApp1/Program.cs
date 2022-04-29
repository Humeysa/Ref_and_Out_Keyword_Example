using System;

namespace ConsoleApp1
{
    class Program
    {
        private static void metot1(int sayi)
        {
            sayi = 1000;
        }

        private static void metot2(ref int sayi)
        {
            sayi = 1000;
        }

        private static void metot3(out int sayi)
        {
            sayi = 1000;
        }

        static void Main(string[] args)
        {
            int deger = 0; //ilk değer ataması yapıldı
            int deger2; //ilk değer ataması yapılmadı

            // deger değişkeninin kopyası gönderilecektir.
            // Ekran Çıktısı: metot1() çağrıldıktan sonra:0
            metot1(deger);
            Console.WriteLine("metot1() çağrıldıktan sonra:{0}", deger);

            // deger değişkeninin adresi gönderilecektir.
            // Ekran Çıktısı: metot2() çağrıldıktan sonra:1000
            metot2(ref deger);
            Console.WriteLine("metot2() çağrıldıktan sonra:{0}", deger);

            // deger değişkeninin adresi gönderilecektir.
            // Ekran Çıktısı: metot3() çağrıldıktan sonra:1000
            metot3(out deger2);
            Console.WriteLine("metot3() çağrıldıktan sonra:{0}", deger2);
        }
    }
}
