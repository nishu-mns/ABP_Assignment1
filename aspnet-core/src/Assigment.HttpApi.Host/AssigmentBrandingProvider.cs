using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Assigment;

[Dependency(ReplaceServices = true)]
public class AssigmentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Assigment";
}
