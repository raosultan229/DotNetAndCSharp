using CSharpApiCourse.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpApiCourse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<HotelNumber> HotelNumber { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    Id = 1,
                    Name = "Serena hotel",
                    Description = "Serena Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia",
                    Rooms = 5,
                    IsAvailable = true,
                    Rate =  20000,
                    Occupancy = 5,
                    ImageUrl = "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=",
                    
                },
                                new Hotel()
                                {
                                    Id = 2,
                                    Name = "PC hotel",
                                    Description = "PC Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia",
                                    Rooms = 5,
                                    IsAvailable = true,
                                    Rate = 10000,
                                    Occupancy = 5,
                                    ImageUrl = "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=",
                                    CreatedDate = DateTime.Now,
                                },
                                                new Hotel()
                                                {
                                                    Id = 3,
                                                    Name = "Nova hotel",
                                                    Description = "Nova Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia",
                                                    Rooms = 3,
                                                    IsAvailable = false,
                                                    Rate = 20000,
                                                    Occupancy = 5,
                                                    ImageUrl = "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=",
                                                    CreatedDate = DateTime.Now,

                                                },
                                                                new Hotel()
                                                                {
                                                                    Id = 4,
                                                                    Name = "Royal hotel",
                                                                    Description = "Serena Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia",
                                                                    Rooms = 3,
                                                                    IsAvailable = true,
                                                                    Rate = 50000,
                                                                    Occupancy = 5,
                                                                    ImageUrl = "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=",
                                                                    CreatedDate = DateTime.Now,

                                                                },
                                                                                new Hotel()
                                                                                {
                                                                                    Id = 5,
                                                                                    Name = "Palace hotel",
                                                                                    Description = "Serena Hotels is a hospitality company which operates up-scale hotels and resorts in East Africa, Southern Africa and South Asia. As of 2023, Serena comprises a collection of 34 luxury resorts, safari lodges, and hotels, which are located in East Africa and Central and South Asia",
                                                                                    Rooms = 6,
                                                                                    IsAvailable = false,
                                                                                    Rate = 70000,
                                                                                    Occupancy = 5,
                                                                                    ImageUrl = "https://media.istockphoto.com/id/1152537185/photo/hacker-working-on-laptop-in-the-dark.jpg?s=2048x2048&w=is&k=20&c=KzdFLKatp_2rsWnsEZRrw1Qkv-shfRTXTEmuX7QUB0I=",
                                                                                    CreatedDate = DateTime.Now,

                                                                                }
                );
            ;
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}