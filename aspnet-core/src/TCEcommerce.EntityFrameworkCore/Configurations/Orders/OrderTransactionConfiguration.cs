﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TCEcommerce.Orders
{
    public class OrderTransactionConfiguration : IEntityTypeConfiguration<OrderTransaction>
    {
        public void Configure(EntityTypeBuilder<OrderTransaction> builder)
        {
            builder.ToTable(TCEcommerceConsts.DbTablePrefix + "OrderTransactions");

            builder.Property(x => x.Code)
                 .HasMaxLength(50)
                 .IsUnicode(false)
                 .IsRequired();
        }
    }
}