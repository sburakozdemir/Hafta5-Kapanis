
using System;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5_Kapanis
{
    public class Araba
    {
        // Otomatik olarak atanan üretim tarihi
        public DateTime UretimTarihi { get; private set; }

        // Araba özellikleri
        public string SeriNumarası { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        // Constructor: Yeni bir Araba nesnesi oluşturulduğunda çağrılır
        public Araba()
        {
            UretimTarihi = DateTime.Now; // Üretim tarihi otomatik olarak atanıyor
        }
    }
}