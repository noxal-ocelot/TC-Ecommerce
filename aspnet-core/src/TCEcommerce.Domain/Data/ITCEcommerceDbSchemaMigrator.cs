using System.Threading.Tasks;

namespace TCEcommerce.Data;

public interface ITCEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
