using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models.Entities
{
    internal class Tur : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<KitapTur> KitapTurleri { get; set; }
    }
}
