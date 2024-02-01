using AutoMapper;
using CSharpApiCourse.Models;
using CSharpApiCourse.Models.Dto;

namespace CSharpApiCourse
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        {
            CreateMap<Hotel, HotelDTO>();
            CreateMap<HotelDTO, Hotel>();

            CreateMap<Hotel, HotelUpdateDTO>().ReverseMap();
            CreateMap<Hotel, HotelCreateDTO>().ReverseMap( );

        }
    }
}
