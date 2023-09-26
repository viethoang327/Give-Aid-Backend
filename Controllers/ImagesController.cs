using BackEnd.Data;
using BackEnd.Model;
using BackEnd.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ImagesController : BaseController<Images>
    {
        private readonly IImagesRepository _imagesRepository;

        public ImagesController(IImagesRepository imagesRepository, DBContext context, IRepository<Images> repository) : base(context, repository)
        {
            _imagesRepository = imagesRepository;
        }
    }
}
