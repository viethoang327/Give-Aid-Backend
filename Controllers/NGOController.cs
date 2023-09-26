using BackEnd.Data;
using BackEnd.Model;
using BackEnd.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
   public class NGOController : BaseController<NGO>
    {
        private readonly INGORepository _NGORespository;

        public NGOController(INGORepository NGORespository, DBContext context, IRepository<NGO> repository) : base(context,repository)
        {
          _NGORespository = NGORespository;
        }
    }
}
