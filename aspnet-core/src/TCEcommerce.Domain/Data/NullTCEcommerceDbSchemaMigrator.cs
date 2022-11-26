using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TCEcommerce.Data;

/* This is used if database provider does't define
 * ITCEcommerceDbSchemaMigrator implementation.
 */
public class NullTCEcommerceDbSchemaMigrator : ITCEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
