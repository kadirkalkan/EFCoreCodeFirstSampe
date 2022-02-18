using EFCoreCodeFirstSample.Models.Entities;
using EFCoreCodeFirstSample.Models.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models.Data
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<YazarDetay> YazarDetaylar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<KitapTur> KitapTurleri { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=KutuphaneDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KitapEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TurEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new YazarEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new KitapTurEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new YazarDetayEntityTypeConfiguration());
        }


    }
}
