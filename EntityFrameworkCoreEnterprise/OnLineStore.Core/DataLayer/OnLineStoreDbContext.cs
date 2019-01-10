using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnLineStore.Core.EntityLayer.Sales;
using OnLineStore.Core.EntityLayer.Dbo;
using OnLineStore.Core.DataLayer.Configurations.Sales;


namespace OnLineStore.Core.DataLayer
{
    public class OnLineStoreDbContext : DbContext
    {

        public OnLineStoreDbContext(DbContextOptions<OnLineStoreDbContext> options) : base(options)
        {

        }

        public DbSet<OrderHeader> OrderHeader { get; set; }

        public DbSet<OrderDetail> OrderDetail { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<ChangeLog> ChangeLogs { get; set; }

        public DbSet<ChangeLogExclusion> ChangeLogExclusions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration(new OrderHeaderConfiguration())
                .ApplyConfiguration(new OrderDetailConfiguration())
                .ApplyConfiguration(new CustomerConfiguration());           


            base.OnModelCreating(modelBuilder);

        }

    }
}
