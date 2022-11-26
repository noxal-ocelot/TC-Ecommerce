using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TCEcommerce;

[Dependency(ReplaceServices = true)]
public class TCEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TCEcommerce";
}
