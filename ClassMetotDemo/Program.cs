using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0001;
            musteri1.Adi = "Faruk Gündoğan";
            musteri1.Tür = "Bireysel";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 0002;
            musteri2.Adi = "Net Holding";
            musteri2.Tür = "Tüzel";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 0003;
            musteri3.Adi = "Mustafa Akalın";
            musteri3.Tür = "Bireysel";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Sil(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.Listele(musteriler);

        }
    }
}
