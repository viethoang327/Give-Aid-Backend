using BackEnd.Data;
using BackEnd.Model;
using BackEnd.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EventsController : BaseController<Events>
    {
        private readonly IEventsRepository _eventsRepository;

        public EventsController(IEventsRepository eventsRepository, DBContext context, IRepository<Events> repository) : base(context, repository)
        {
            _eventsRepository = eventsRepository;
        }
    }
}
