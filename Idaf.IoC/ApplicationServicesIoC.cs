using Idaf.Infraestrutura.EntityFramework;
using Idaf.Infraestrutura.Interfaces;
using Idaf.Infraestrutura.Interfaces.Services.Users;
using Idaf.Infraestrutura.Repositorioes.Domain.EFCore;
using Idaf.Infraestrutura.Repositorioes.Domain.EFCore.Base;
using Idaf.Infraestrutura.Services.Base;
using Idaf.Infraestrutura.Services.Users;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idaf.IoC
{
    public static class ServicesIoC
    {
        public static void ApplicationServicesIoC(this IServiceCollection services)
        {
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));

            services.AddScoped<IUserService, UserService>();


        }
    }
}
