using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Model
{
    public class Queries : BaseModel
    {
        public string? Content { get; set; }
        public string? Statust { get; set; }
        [ForeignKey(nameof(User))]
        public int? UserID { get; set; }
        public Users? User { get; set; }
    }
}
