using EFCoreCodeFirstSample.Models.Entities;
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
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<KitapTur> KitapTurleri { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=KutuphaneDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KitapTur>().HasKey(x => new { x.KitapId, x.TurId });
            modelBuilder.Entity<Tur>().HasData(
                new Tur() { Id = 1, Name = "Fantezi" },
                new Tur() { Id = 2, Name = "Macera" }
                );
        }


    }
}
