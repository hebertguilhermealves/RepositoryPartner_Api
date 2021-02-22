using Idaf.Dominio.Entidades;
using Idaf.Infraestrutura.Interfaces.Services.Users;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Idaf.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _userService.GetAllAsync();
        }

        [HttpPost]
        public async Task Insert(User model)
        {
            try
            {
                await _userService.AddAsync(model);
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
