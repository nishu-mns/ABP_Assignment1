using System;
using System.Collections.Generic;
using System.Text;
using Assigment.Localization;
using Volo.Abp.Application.Services;

namespace Assigment;

/* Inherit your application services from this class.
 */
public abstract class AssigmentAppService : ApplicationService
{
    protected AssigmentAppService()
    {
        LocalizationResource = typeof(AssigmentResource);
    }
}
