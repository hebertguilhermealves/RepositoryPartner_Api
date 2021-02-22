using Idaf.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idaf.Infraestrutura.Interfaces
{
    public interface IDomainRepository<TEntity> : IRepositoryAsync<TEntity> where TEntity : class, IIdentityEntity
    {
    }
}
