using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<ProductEntity> Products {get; set; }
        public DbSet<CategoryEntity> Categories {get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouses {get; set; }
        public DbSet<StorageEntity> Storages {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Data Source=DESKTOP-IGNH3JV\BOCCHI;Initial Catalog=Inventory;Integrated Security=True");    //StringConection
            }
        }

        //Cargar datos antes de crear la BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            base.OnModelCreating(modelBuilder);     //base: metodo que ya existe dentro de DBContext

            modelBuilder.Entity<CategoryEntity>().HasData(  //Cateroria
                new CategoryEntity { CategoryId = "VDG", CategoryName = "Video Games" },
                new CategoryEntity { CategoryId = "STW", CategoryName = "Software" },
                new CategoryEntity { CategoryId = "DVD", CategoryName = "Video" },
                new CategoryEntity { CategoryId = "AUD", CategoryName = "Audio" },
                new CategoryEntity { CategoryId = "GTS", CategoryName = "Gadgets" },
                new CategoryEntity { CategoryId = "MSC", CategoryName = "Music" }
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(  //bodega
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Central", WarehouseAddress = "Los santos" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega local", WarehouseAddress = "Grove Street" },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Norte", WarehouseAddress = "Las Venturas" }
                );

            //modelBuilder.Entity<ProductEntity>().HasData(  //producto
            //    new ProductEntity { ProductId = "NR4-59264", ProductName = "RTX 4090 Ti", PuoductDescription = "a" },
            //    new ProductEntity { ProductId = "IC9-59264", ProductName = "Intel I12-15900K", PuoductDescription = "a" }
            //    );
        }
    }
}
