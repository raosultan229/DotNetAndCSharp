using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpApiCourse.Models
{
    public class Hotel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public bool IsAvailable { get; set; }
        public double Rate { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; }
    }
}
