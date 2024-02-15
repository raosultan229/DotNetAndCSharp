using CSharpApiCourse.Models;
using System.Linq.Expressions;

namespace CSharpApiCourse.Repository.IRepository
{
    public interface IHotelNumberRepository : IRepository<HotelNumber>
    {
         Task<HotelNumber> UpdateAsync(HotelNumber entity);

    }
}
