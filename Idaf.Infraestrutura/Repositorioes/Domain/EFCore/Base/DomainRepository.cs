using Idaf.Dominio.Interfaces;
using Idaf.Infraestrutura.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idaf.Infraestrutura.Repositorioes.Domain.EFCore.Base
{
    public class DomainRepository<TEntity> : RepositoryAsync<TEntity>,
                                         IDomainRepository<TEntity> where TEntity : class, IIdentityEntity
    {
        protected DomainRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
