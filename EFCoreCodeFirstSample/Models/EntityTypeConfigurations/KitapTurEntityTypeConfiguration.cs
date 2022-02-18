using EFCoreCodeFirstSample.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models.EntityTypeConfigurations
{
    internal class KitapTurEntityTypeConfiguration : IEntityTypeConfiguration<KitapTur>
    {
        public void Configure(EntityTypeBuilder<KitapTur> builder)
        {
            builder.ToTable("KitapTurleri");

            builder.HasKey(x => new { x.KitapId, x.TurId });

            builder
                .HasOne(kitapTur => kitapTur.Kitap)
                .WithMany(kitap => kitap.KitapTurleri)
                .HasForeignKey(kitapTur => kitapTur.KitapId);

            builder
                .HasOne(kitapTur => kitapTur.Tur)
                .WithMany(tur => tur.KitapTurleri)
                .HasForeignKey(kitapTur => kitapTur.TurId);
        }
    }
}
