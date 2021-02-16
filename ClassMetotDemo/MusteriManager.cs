using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" hizmet numaralı "+musteri.Adi+" isimli müşleri sisteme ekelendi.");
            Console.WriteLine(" ");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " hizmet numaralı " + musteri.Adi + " isimli müşleri sistemden silindi.");
            Console.WriteLine(" ");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine("Id: "+musteri.Id);
                Console.WriteLine("Adı: " + musteri.Adi);
                Console.WriteLine("Türü: " + musteri.Tür);
                Console.WriteLine(" ");
            }
        }
    }
}
