using BackEnd.Data;
using BackEnd.Model;

namespace BackEnd.Repository
{
    public interface IUsersRepository : IRepository<Users>
    {
    }
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(DBContext dBContext) : base(dBContext)
        {

        }
    }
}
