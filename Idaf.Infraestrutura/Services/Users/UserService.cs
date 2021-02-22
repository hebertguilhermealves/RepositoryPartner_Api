using Idaf.Dominio.Entidades;
using Idaf.Infraestrutura.EntityFramework;
using Idaf.Infraestrutura.Interfaces.Services.Users;
using Idaf.Infraestrutura.Services.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Idaf.Infraestrutura.Services.Users
{
    public class UserService : ServiceBase<User>,
                           IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<User>> GetAllIncludingTasksAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<User> GetByIdIncludingTasksAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
