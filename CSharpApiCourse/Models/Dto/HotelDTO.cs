using System.ComponentModel.DataAnnotations;

namespace CSharpApiCourse.Models.Dto
{
    public class HotelDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public bool IsAvailable { get; set; }

        [Required]
        public double Rate { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; }
        

    }
}
