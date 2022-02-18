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
    internal class YazarDetayEntityTypeConfiguration : IEntityTypeConfiguration<YazarDetay>
    {
        public void Configure(EntityTypeBuilder<YazarDetay> builder)
        {
            builder.ToTable("YazarDetaylari");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(255);

            builder.HasOne(yazarDetay => yazarDetay.Yazar)
                .WithOne(yazar => yazar.YazarDetay)
                .HasForeignKey<YazarDetay>(x => x.Id);
        
        }
    }
}
