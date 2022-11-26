using TCEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TCEcommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TCEcommerceController : AbpControllerBase
{
    protected TCEcommerceController()
    {
        LocalizationResource = typeof(TCEcommerceResource);
    }
}
