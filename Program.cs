using Microsoft.EntityFrameworkCore;
using TripPlannerAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 34))));

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();
