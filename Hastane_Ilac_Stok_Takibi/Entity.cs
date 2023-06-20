using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Ilac_Stok_Takibi
{
    public class Ilac
    {
        public Guid IlacID { get; set; }
        public string IlacAdi { get; set; }
        public int StokMiktari { get; set; }
        public string KategoriID  { get; set; }
        public string HastalarTC { get; set; }
    }
}


    public class Calısanlar
    {
       public Guid CalisanlarID { get; set; }
       public string CalisanlarAdi { get; set; }
       public string CalisanlarSoyadi { get; set; }
       public string CalisanlarTelefon { get; set; }
       public string CalisanlarMail { get; set; }
    }


    public class Hastalar
    {
       public Guid HastalarTC { get; set; }
       public String HastalarAdi { get; set; }
       public string HastalarSoyadi { get; set; }
       public string HastalarRecete { get; set; }
       public string IlacID { get; set; }
    
    }

    public class Kategori
    {
      public Guid KategoriID { get; set; }
      public string KategoriAdi { get; set; }
      public string IlacID { get; set; }
    }




