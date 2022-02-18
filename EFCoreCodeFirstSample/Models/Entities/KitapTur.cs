using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models.Entities
{
    internal class KitapTur
    {    
        public int KitapId { get; set; }
        public Kitap Kitap{ get; set; }

        public int TurId { get; set; }
        public Tur Tur { get; set; }
    }
}
