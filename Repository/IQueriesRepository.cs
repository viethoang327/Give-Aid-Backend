using BackEnd.Data;
using BackEnd.Model;

namespace BackEnd.Repository
{
    public interface IQueriesRepository : IRepository<Queries>
    {
    }
    public class QueriesRepository : Repository<Queries>, IQueriesRepository
    {
        public QueriesRepository(DBContext dBContext) : base(dBContext)
        {

        }
    }
}
