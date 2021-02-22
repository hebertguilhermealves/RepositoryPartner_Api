using Idaf.Dominio.Entidades;
using Idaf.Infraestrutura.DBConfiguration.EFCore;
using Idaf.Infraestrutura.EntityFramework;
using Idaf.Infraestrutura.Repositorioes.Domain.EFCore.Base;

namespace Idaf.Infraestrutura.Repositorioes.Domain.EFCore
{
    public class UserRepository : DomainRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }


    }
}
