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
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {

            builder.HasKey(p => p.OrderDetailID);

            builder.Property(p => p.OrderDetailID);
            builder.Property(p => p.OrderHeaderID);


            builder.Property(p => p.ProductID);
            builder.Property(p => p.ProductName);
            builder.Property(p => p.UnitPrice);
            builder.Property(p => p.Quantity);

            builder.Property(p => p.Total);
            builder.Property(p => p.CreationUser);
            builder.Property(p => p.CreationDateTime);
            builder.Property(p => p.LastUpdateUser);
            builder.Property(p => p.LastUpdateDateTime);

            builder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();

        }
    }
}
