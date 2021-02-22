using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Idaf.Infraestrutura.IoC
{
    public interface IOrmTypes
    {
        IServiceCollection ResolveOrm(IServiceCollection services, IConfiguration configuration = null);
    }
}
