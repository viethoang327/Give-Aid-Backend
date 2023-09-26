using BackEnd.Data;
using BackEnd.Model;

namespace BackEnd.Repository
{
    public interface IEventsRepository : IRepository<Events>
    {
    }
    public class EventsRepository : Repository<Events>, IEventsRepository
    {
        public EventsRepository(DBContext dBContext) : base(dBContext)
        {

        }
    }

}
