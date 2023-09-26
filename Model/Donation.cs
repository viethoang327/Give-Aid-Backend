using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Model
{
    public class Donation : BaseModel
    {
        public float? Amount { get; set; }
        public DateTime? DonationDate { get; set; }
        public string? Donation_Type { get; set; }
        [ForeignKey(nameof(User))]
        public int? UserID { get; set; }
        public Users? User { get; set; }
        [ForeignKey(nameof(Events))]
        public int? EventID { get; set; }
        public Events? Events { get; set; }
    }
}
