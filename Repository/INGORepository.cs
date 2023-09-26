using BackEnd.Data;
using BackEnd.Model;

namespace BackEnd.Repository
{
    public interface INGORepository : IRepository<NGO>
    {
    }
    public class NGORepository : Repository<NGO>, INGORepository
    {
        public NGORepository(DBContext dBContext) : base(dBContext)
        { 

        }
    }

}
