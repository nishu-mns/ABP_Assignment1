using System.Threading.Tasks;

namespace Assigment.Data;

public interface IAssigmentDbSchemaMigrator
{
    Task MigrateAsync();
}
