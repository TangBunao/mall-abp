using System.Threading.Tasks;

namespace TangBunao.Mall.Data
{
    public interface IMallDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
