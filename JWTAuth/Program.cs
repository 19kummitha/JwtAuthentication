using JWTAuth.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AuthenticationDbContext>(options =>
{
    var Connectionstring = builder.Configuration.GetConnectionString("AuthDbConnection");
    options.UseSqlServer(Connectionstring);
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
