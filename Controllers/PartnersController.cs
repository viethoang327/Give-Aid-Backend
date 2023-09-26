using BackEnd.Data;
using BackEnd.Model;
using BackEnd.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PartnersController : BaseController<Partners>
    {
        private readonly IPartnersRepository _partnersRepository;

        public PartnersController(IPartnersRepository partnersRepository, DBContext context, IRepository<Partners> repository) : base(context, repository)
        {
            _partnersRepository = partnersRepository;
        }
    }
}
