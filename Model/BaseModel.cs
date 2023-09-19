using System.ComponentModel.DataAnnotations;

namespace BackEnd.Model
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; }
        public bool? isDeleted { get; set; }
        public DateTime? DeleteAt { get; set; } = DateTime.Now;
        public string? DeleteBy { get; set; }

    }
}
