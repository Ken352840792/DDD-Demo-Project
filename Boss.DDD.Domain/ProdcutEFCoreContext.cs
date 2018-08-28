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
            optionsBuilder.UseSqlServer("data source=192.168.1.114;initial catalog=Test1;persist security info=True;user id=sa;password=qwer4321!@#$;MultipleActiveResultSets=True");
        }
    }
}