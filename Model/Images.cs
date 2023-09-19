using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Model
{
    public class Images : BaseModel
    {
        public string? Path { get; set; }
        public string? Description { get; set; }
        [ForeignKey(nameof(Events))]
        public int? EventID { get; set; }
        public Events? Events { get; set; }
    }
}
