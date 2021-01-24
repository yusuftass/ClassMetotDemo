using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri[] musteriler)
        {
            Console.WriteLine("Musteri bilgileri giriniz");
            Console.WriteLine("ID : ");
            var musteriId = Console.ReadLine();
            Console.WriteLine("Adi   : ");
            var musteriAdi = Console.ReadLine();
            Console.WriteLine("Soyadi: ");
            var musteriSoyadi = Console.ReadLine();
            Console.WriteLine("TC    : ");
            var musteriTC = Console.ReadLine();
            Console.WriteLine("Approve ? (Y/N) :");
            var approve = Console.ReadLine();

            if (approve.ToUpper() == "Y")
            {
                Console.WriteLine("Müşteri Eklendi");
            }
        }
        public void MusteriSil(Musteri[] musteriler)
        {
            Console.WriteLine("Silinecek musterinin ID si giriniz : ");
            var Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Id + " Id sine sahip musteri silinsin mi?");
            var approve = Console.ReadLine();
            if (approve.ToUpper() == "Y")
            {
                Console.WriteLine("Müşteri Silindi");
            }
        }
        public void MusteriList(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Id " + musteri.Id);
                Console.WriteLine("Adi: " + musteri.Adi);
                Console.WriteLine("Soyadi: " + musteri.Soyadi);
                Console.WriteLine("TC: " + musteri.TC);
                Console.WriteLine("---------------------------");
            }
        }

    }
}