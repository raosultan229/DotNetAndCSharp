using CSharpApiCourse.Models;
using System.Linq.Expressions;

namespace CSharpApiCourse.Repository.IRepository
{
    public interface IHotelRepository : IRepository<Hotel>
    {
         Task<Hotel> UpdateAsync(Hotel entity);

    }
}
