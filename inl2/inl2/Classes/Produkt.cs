using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inl2
{
   public class Produkt : Kategori
    {
        public int ArtikelId { get; set; }
        public string Märke { get; set; }
        public string Storlek { get; set; }
        public int Saldo { get; set; }
        public string Namn { get; set; }
        public int Pris { get; set; }


    }
}
