using BackEnd.Data;
using BackEnd.Model;
using BackEnd.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class DonationController : BaseController<Donation>
    {
        private readonly IDonationRepository _donationRepository;

        public DonationController(IDonationRepository donationRepository, DBContext context, IRepository<Donation> repository) : base(context, repository)
        {
            _donationRepository = donationRepository;
        }
    }
}
