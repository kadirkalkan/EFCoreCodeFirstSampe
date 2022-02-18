using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models.Entities
{
    internal class Kitap : BaseEntity
    {
        public string Name { get; set; }
        public int SayfaSayisi { get; set; }
        public int BasimYili { get; set; }
        public DateTime EklenmeTarihi { get; set; } = DateTime.Now;
        public decimal Fiyat { get; set; }

        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

        public ICollection<KitapTur> KitapTurleri { get; set; }
    }
}
