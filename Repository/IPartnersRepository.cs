using BackEnd.Data;
using BackEnd.Model;

namespace BackEnd.Repository
{
    public interface IPartnersRepository : IRepository <Partners>
    {
    }
    public class PartnersRepository : Repository<Partners>, IPartnersRepository
    {
        public PartnersRepository(DBContext dBContext) : base(dBContext)
        {

        }
    }
}
