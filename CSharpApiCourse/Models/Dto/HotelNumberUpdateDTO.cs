using System.ComponentModel.DataAnnotations;

namespace CSharpApiCourse.Models.Dto
{
    public class HotelNumberUpdateDTO
    {
        [Required]
        public int HotelNo { get; set; }
        public string AdditionalDetails { get; set; }

    }
}
