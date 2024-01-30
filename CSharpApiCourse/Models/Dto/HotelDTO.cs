using System.ComponentModel.DataAnnotations;

namespace CSharpApiCourse.Models.Dto
{
    public class HotelDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public bool IsAvailable { get; set; }
    }
}
