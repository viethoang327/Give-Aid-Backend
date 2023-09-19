using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Model
{
    public class Events : BaseModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
        public string? Location { get; set; }
        [ForeignKey(nameof(NGO))]
        public int NGOID { get; set; }
        public NGO? NGO { get; set; }
    }
}
