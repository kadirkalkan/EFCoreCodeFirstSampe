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
    internal class KitapEntityTypeConfiguration : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            //EntityTypeBuilder<Kitap>   ==   modelBuilder.Entity<Kitap>()
            builder.ToTable("Kitaplar");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x=> x.Name).IsRequired();
            builder.Property(x=> x.Name).HasMaxLength(50);

            builder.Property(x=> x.SayfaSayisi).IsRequired();   
            
            builder.Property(x=> x.BasimYili).IsRequired();

            builder.Property(x => x.EklenmeTarihi).HasDefaultValueSql("getdate()");

            builder.Property(x => x.Fiyat).HasPrecision(18, 2);
            builder.Property(x => x.Fiyat).HasColumnType("decimal(18, 2)");

            builder
                .HasOne(kitap=> kitap.Yazar)
                .WithMany(yazar => yazar.Kitaplar)
                .HasForeignKey(kitap=>kitap.YazarId);
        }
    }
}
