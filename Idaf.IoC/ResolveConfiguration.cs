using Idaf.Infraestrutura.DBConfiguration;
using Microsoft.Extensions.Configuration;

namespace Idaf.IoC
{
    internal class ResolveConfiguration
    {
        public static IConfiguration GetConnectionSettings(IConfiguration configuration)
        {
            return configuration ?? DatabaseConnection.ConnectionConfiguration;
        }
    }
}
