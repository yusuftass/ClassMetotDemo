using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Yusuf";
            musteri1.Soyadi = "Taş";
            musteri1.TC = 4562678901;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Veysi";
            musteri2.Soyadi = "Koç";
            musteri2.TC = 22378578901;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Erkal";
            musteri3.Soyadi = "Taşkesen";
            musteri3.TC = 22754688901;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            int secim = 1;

            do
            {
                Console.Clear();
                Console.WriteLine("1.Ekle");
                Console.WriteLine("2.Cikar");
                Console.WriteLine("3.Liste");
                Console.WriteLine("0.Cikis");
                secim = Convert.ToInt32(Console.ReadLine());
            }
            while ((secim < 0) | (secim > 3));
            switch (secim)
            {
                case 1:
                    musteriManager.MusteriEkle(musteriler);
                    break;
                case 2:
                    musteriManager.MusteriSil(musteriler);
                    break;
                case 3:
                    musteriManager.MusteriList(musteriler);
                    break;
                default:
                    break;
            }





            //var silId = Console.ReadLine("Musteri Id :");
            //var approve = Console.ReadLine("Emin misiniz ? (Y/N) : ");
            //if (approve.ToUpper = "Y")
            //{
            //    musteriManager.MusteriSil(silId);
            //}


            // Not:Bir Bankada Müşteri Takibi Nasıl Yapılır Adlı Çalışmamız.
            


        }
    }
}