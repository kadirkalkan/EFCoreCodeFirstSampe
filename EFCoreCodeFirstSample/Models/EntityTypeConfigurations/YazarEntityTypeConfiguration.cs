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
    internal class YazarEntityTypeConfiguration : IEntityTypeConfiguration<Yazar>
    {
        public void Configure(EntityTypeBuilder<Yazar> builder)
        {
            builder.ToTable("Yazarlar");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Ad).IsRequired();
            builder.Property(x => x.Ad).HasMaxLength(50);

            builder.Property(x => x.Soyad).IsRequired();
            builder.Property(x => x.Soyad).HasMaxLength(50);
        }
    }
}
