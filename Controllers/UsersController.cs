using BackEnd.Data;
using BackEnd.Model;
using BackEnd.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UsersController : BaseController<Users>
    {
        private readonly IUsersRepository _usersRepository;

        public UsersController(IUsersRepository usersRepository, DBContext context, IRepository<Users> repository) : base(context, repository)
        {
            _usersRepository = usersRepository;
        }
    }
}
