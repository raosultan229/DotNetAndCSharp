using CSharpApiCourse.Data;
using CSharpApiCourse.Models;
using CSharpApiCourse.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace CSharpApiCourse.Repository
{
    public class HotelRepository : Repository<Hotel>, IHotelRepository
    {
        private readonly ApplicationDbContext _db;
        public HotelRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Hotel> UpdateAsync(Hotel entity)
        {
            _db.Hotels.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

    }
}
