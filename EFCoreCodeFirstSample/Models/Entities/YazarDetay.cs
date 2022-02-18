using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models.Entities
{
    internal class YazarDetay : BaseEntity
    {
        public string Address { get; set; }

        public virtual Yazar Yazar { get; set; }
    }
}
