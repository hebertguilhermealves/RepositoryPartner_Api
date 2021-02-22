using Idaf.Dominio.Entidades;
using Idaf.Infraestrutura.Interfaces;

namespace Idaf.Infraestrutura.EntityFramework
{
    public interface IUserRepository : IDomainRepository<User>
    {
       
    }
}
