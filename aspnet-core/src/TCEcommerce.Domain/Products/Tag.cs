using Volo.Abp.Domain.Entities;

namespace TCEcommerce.Products
{
    public class Tag : Entity<string>
    {
        public string Name { get; set; }
    }
}