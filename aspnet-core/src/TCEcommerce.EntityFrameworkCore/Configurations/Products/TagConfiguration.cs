﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TCEcommerce.Products
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable(TCEcommerceConsts.DbTablePrefix + "Tags");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
             .HasMaxLength(50)
             .IsRequired();
            builder.Property(x => x.Name)
               .HasMaxLength(50)
               .IsRequired();

        }
    }
}