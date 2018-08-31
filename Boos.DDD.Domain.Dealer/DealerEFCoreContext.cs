using Boss.DDD.POCOModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boss.DDD
{
    public class DealerEFCoreContext : DbContext, IDealerContext
    {
        public DbSet<Dealers> Dealers { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<DealerTree> DealerTree { get; set; }
        public DbSet<Login> Login { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=192.168.1.114;initial catalog=Test1;persist security info=True;user id=sa;password=qwer4321!@#$;MultipleActiveResultSets=True");
        }
    }
}