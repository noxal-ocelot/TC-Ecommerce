﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TCEcommerce.InventoryTickets
{
    public class InventoryTicketConfiguration : IEntityTypeConfiguration<InventoryTicket>
    {
        public void Configure(EntityTypeBuilder<InventoryTicket> builder)
        {
            builder.ToTable(TCEcommerceConsts.DbTablePrefix + "InventoryTickets");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsRequired();
        }
    }
}
