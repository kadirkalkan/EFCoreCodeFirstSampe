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
    internal class TurEntityTypeConfiguration : IEntityTypeConfiguration<Tur>
    {
        public void Configure(EntityTypeBuilder<Tur> builder)
        {
            builder.ToTable("Turler");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(50);

            builder.HasData(
              new Tur() { Id = 1, Name = "Fantezi" },
              new Tur() { Id = 2, Name = "Macera" }
              );
        }
    }
}
