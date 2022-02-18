using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models.Entities
{
    [Table("Kitaplar")]
    internal class Kitap : BaseEntity
    {
        public string Name { get; set; }
        public int SayfaSayisi { get; set; }
        public int BasimYili { get; set; }


        [ForeignKey("Yazar")]
        public int YazarId { get; set; }
        public Yazar Yazar { get; set; }

        public ICollection<KitapTur> KitapTurleri { get; set; }
    }
}
