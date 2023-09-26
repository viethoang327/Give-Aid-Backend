using BackEnd.Data;
using BackEnd.Model;

namespace BackEnd.Repository
{
    public interface IDonationRepository : IRepository <Donation>
    {
    }
    public class DonationRepository : Repository<Donation>, IDonationRepository
    {
        public DonationRepository(DBContext dBContext) : base(dBContext)
        {

        }
    }
}
