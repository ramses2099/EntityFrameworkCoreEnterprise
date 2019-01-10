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
    public class OrderHeaderConfiguration : IEntityTypeConfiguration<OrderHeader>
    {
        public void Configure(EntityTypeBuilder<OrderHeader> builder)
        {

            // Mapping for table
            //builder.ToTable("OrderHeader", "Sales");

            //Set key for entity
            builder.HasKey(p => p.OrderHeaderID);

            //Set identity for entity(auto increment)
            //builder.Property(p => p.OrderHeaderID).UseSqlServerIdentityColumn();
            builder.Property(p => p.OrderStatusID);

            builder.Property(p => p.CustomerID);
            builder.Property(p => p.EmployeeID);
            builder.Property(p => p.ShipperID);
            builder.Property(p => p.OrderDate);
            builder.Property(p => p.Total);
            builder.Property(p => p.CurrencyID);
            builder.Property(p => p.PaymentMethodID);
            builder.Property(p => p.DetailsCount);
            builder.Property(p => p.ReferenceOrderID);
            builder.Property(p => p.Comments);
            builder.Property(p => p.CreationUser);
            builder.Property(p => p.CreationDateTime);
            builder.Property(p => p.LastUpdateUser);
            builder.Property(p => p.LastUpdateDateTime);

            builder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();


        }
    }
}
