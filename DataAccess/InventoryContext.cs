using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Server=DESKTOP-TUFKNUD\AXELSQLSERVER;Database=InventoryDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryID = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryID = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryID = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryID = "PRF", CategoryName = "Perfumería" },
                new CategoryEntity { CategoryID = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryID = "VDJ", CategoryName = "Video Juegos" });

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity 
                {
                    WarehouseID = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Central",
                    WarehouseAddress = "Dirección 1"
                },
                new WarehouseEntity
                {
                    WarehouseID = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Occidental",
                    WarehouseAddress = "Dirección 25"
                },
                new WarehouseEntity
                {
                    WarehouseID = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Clandestina",
                    WarehouseAddress = "Dirección Desconocida"
                });
        }
    }
}
