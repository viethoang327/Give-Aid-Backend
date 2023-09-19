using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Model
{
    public class Partners : BaseModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Logo { get; set; }
        [ForeignKey(nameof(NGO))]
        public int? NGOID { get; set; }
        public NGO? NGO { get; set; }
    }
}
