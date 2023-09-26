using Microsoft.EntityFrameworkCore;
using SuperHeroAPIDotNet7.Data;
using SuperHeroAPIDotNet7.Repository.IServices;
using SuperHeroAPIDotNet7.Repository.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options =>
options.UseMySql(builder.Configuration.GetConnectionString("SuperCS"), ServerVersion.Parse("8.0.28"))
 );

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISuperHeroService, SuperHeroService>();

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

app.Run();
