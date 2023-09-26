using BackEnd.Data;
using BackEnd.Model;

namespace BackEnd.Repository
{
    public interface IImagesRepository: IRepository<Images>
    {
    }
    public class ImagesRepository : Repository<Images>, IImagesRepository
    {
        public ImagesRepository(DBContext dBContext) : base(dBContext)
        {

        }
    }
}
