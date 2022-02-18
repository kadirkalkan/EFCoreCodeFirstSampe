using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models.Entities
{
    internal class Yazar : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }


        public YazarDetay YazarDetay { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
