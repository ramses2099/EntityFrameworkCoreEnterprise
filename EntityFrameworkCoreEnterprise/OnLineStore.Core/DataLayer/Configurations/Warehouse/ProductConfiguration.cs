using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnLineStore.Core.EntityLayer.Warehouse;

namespace OnLineStore.Core.DataLayer.Configurations.Warehouse
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Mapping for table
            builder.ToTable("Product", "Warehouse");

            //Set key for entity
            builder.HasKey(p => p.ProductID);

            //Set identity for enttiy (auto increment)
            builder.Property(p => p.ProductID).UseSqlServerIdentityColumn();

            builder.Property(p => p.ProductName).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.ProductCategoryID).HasColumnType("int").IsRequired();
            builder.Property(p => p.UnitPrice).HasColumnType("decimal(12,4)").IsRequired();
            builder.Property(p => p.Description).HasColumnType("varchar(255)");
            builder.Property(p => p.Discontinued).HasColumnType("bit").IsRequired();
            builder.Property(p => p.UnitPrice).HasColumnType("decimal(12,4)").IsRequired();
            builder.Property(p => p.Stocks).HasColumnType("int").IsRequired();
            builder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            builder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            builder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");


            builder.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();


        }
    }
}
