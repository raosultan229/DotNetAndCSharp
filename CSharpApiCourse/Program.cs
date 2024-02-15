using CSharpApiCourse;
using CSharpApiCourse.Data;
using CSharpApiCourse.Repository;
using CSharpApiCourse.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
//Adding Log File
Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("log/hotelLogs.txt", rollingInterval: RollingInterval.Month).CreateLogger();
builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(option => { option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection")); });
builder.Services.AddScoped<IHotelRepository, HotelRepository>();
builder.Services.AddScoped<IHotelNumberRepository, HotelNumberRepository>();
builder.Services.AddAutoMapper(typeof(MappingConfig));
builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors(cors =>
{
    cors.AllowAnyOrigin().
        AllowAnyMethod().AllowAnyHeader();
});

app.Run();
