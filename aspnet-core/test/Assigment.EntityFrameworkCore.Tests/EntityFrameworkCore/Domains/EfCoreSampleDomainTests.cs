using Assigment.Samples;
using Xunit;

namespace Assigment.EntityFrameworkCore.Domains;

[Collection(AssigmentTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AssigmentEntityFrameworkCoreTestModule>
{

}
