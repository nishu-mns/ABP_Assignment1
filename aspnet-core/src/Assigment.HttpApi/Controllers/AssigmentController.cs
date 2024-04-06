using Assigment.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Assigment.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AssigmentController : AbpControllerBase
{
    protected AssigmentController()
    {
        LocalizationResource = typeof(AssigmentResource);
    }
}
