using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnLineStore.Core.EntityLayer.Sales;


namespace OnLineStore.Core.DataLayer.Configurations.Sales
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer", "Sales");

            builder.HasKey(p => p.CustomerID);

            builder.Property(p => p.CustomerID).UseSqlServerIdentityColumn();


            builder.Property(p => p.CustomerID);
            builder.Property(p => p.CompanyName);
            builder.Property(p => p.ContactName);
            builder.Property(p => p.CreationUser);
            builder.Property(p => p.CreationDateTime);
            builder.Property(p => p.LastUpdateUser);
            builder.Property(p => p.LastUpdateDateTime);

            builder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

        }
    }
}
