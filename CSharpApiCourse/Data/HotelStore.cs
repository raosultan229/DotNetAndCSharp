using CSharpApiCourse.Models.Dto;
using System.ComponentModel.DataAnnotations;

namespace CSharpApiCourse.Data
{
    public static class HotelStore
    {

        public static List<HotelDTO> hotelList = new List<HotelDTO>
            {
                new HotelDTO{Id=1, Name="Serena", Description="This is your Serena Hotel", Rooms=4, IsAvailable=true},
                new HotelDTO{Id=2, Name="PC",  Description="This is your PC Hotel", Rooms=10, IsAvailable=false }
            };
    }
}
