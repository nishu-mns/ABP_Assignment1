using Assigment.Samples;
using Xunit;

namespace Assigment.EntityFrameworkCore.Applications;

[Collection(AssigmentTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AssigmentEntityFrameworkCoreTestModule>
{

}
