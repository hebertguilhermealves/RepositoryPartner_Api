using Idaf.Infraestrutura.DBConfiguration.EFCore;
using Idaf.Infraestrutura.EntityFramework;
using Idaf.Infraestrutura.Interfaces;
using Idaf.Infraestrutura.Repositorioes.Domain.EFCore;
using Idaf.Infraestrutura.Repositorioes.Domain.EFCore.Base;
using Idaf.IoC;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Idaf.Infraestrutura.IoC
{
    public class EntityFrameworkIoC : OrmTypes
    {
        internal override IServiceCollection AddOrm(IServiceCollection services, IConfiguration configuration = null)
        {
            IConfiguration dbConnectionSettings = ResolveConfiguration.GetConnectionSettings(configuration);

            string conn = dbConnectionSettings.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(conn));

            services.AddScoped(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}