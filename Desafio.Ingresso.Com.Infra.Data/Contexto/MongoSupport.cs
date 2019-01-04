using Microsoft.Extensions.DependencyInjection;

namespace Desafio.Ingresso.Com.Infra.Data.Contexto
{
    public static class MongoSupport
    {
        public static void AddMongo(this IServiceCollection services, string connectionString, string dataBase)
        {
            ConnectionString = connectionString;
            Database = dataBase;
        }

        public static string ConnectionString;
        public static string Database;
    }
}
