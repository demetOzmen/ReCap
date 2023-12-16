﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class ProductConfiguration
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("ProductID").IsRequired();
            builder.Property(b => b.CategoryId).HasColumnName("CategoryId").IsRequired();
            builder.Property(b => b.ProductName).HasColumnName("ProductName").IsRequired();
            builder.Property(b => b.UnitPrice).HasColumnName("UnitPrice");
            builder.Property(b => b.UnitsInStock).HasColumnName("UnitsInStock");
            builder.Property(b => b.QuantityPerUnit).HasColumnName("QuantityPerUnit");


            builder.HasIndex(indexExpression: b => b.ProductName, name: "UK_Products_ProductName").IsUnique();

            builder.HasOne(b => b.Category);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
