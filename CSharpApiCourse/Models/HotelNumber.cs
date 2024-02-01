using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpApiCourse.Models
{
    public class HotelNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HotelNo { get; set; }
        public string AdditionalDetails { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
