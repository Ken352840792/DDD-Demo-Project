using Boss.DDD.POCOModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    public class ProdcutEFCoreContext : DbContext, IProdcutContext
    {
        public DbSet<ProductSPU> ProductSPUs { get; set; }
        public DbSet<ProductSKU> ProductSKUs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppSetting.GetAppSetting("ProductContext"));
        }
    }
}