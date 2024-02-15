using CSharpApiCourse.Data;
using CSharpApiCourse.Models;
using CSharpApiCourse.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace CSharpApiCourse.Repository
{
    public class HotelNumberRepository : Repository<HotelNumber>, IHotelNumberRepository
    {
        private readonly ApplicationDbContext _db;
        public HotelNumberRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<HotelNumber> UpdateAsync(HotelNumber entity)
        {
            //entity.UpdatedDate = DateTime.Now;
            _db.HotelNumber.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

    }
}
