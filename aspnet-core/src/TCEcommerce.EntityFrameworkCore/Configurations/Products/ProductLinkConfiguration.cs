using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TCEcommerce.Products
{
    public class ProductLinkConfiguration : IEntityTypeConfiguration<ProductLink>
    {
        public void Configure(EntityTypeBuilder<ProductLink> builder)
        {
            builder.ToTable(TCEcommerceConsts.DbTablePrefix + "ProductLinks");
            builder.HasKey(x => new { x.ProductId, x.LinkedProductId });
        }
    }
}