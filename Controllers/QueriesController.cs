using BackEnd.Data;
using BackEnd.Model;
using BackEnd.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class QueriesController : BaseController<Queries>
    {
        private readonly IQueriesRepository _queriesRepository;

        public QueriesController(IQueriesRepository queriesRepository, DBContext context, IRepository<Queries> repository) : base(context, repository)
        {
            _queriesRepository = queriesRepository;
        }
    }
}
