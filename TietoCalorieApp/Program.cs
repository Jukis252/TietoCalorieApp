using Microsoft.EntityFrameworkCore;
using TietoCalorieApp.Data;
using TietoCalorieApp.Models;
using TietoCalorieApp.Repositories;
using TietoCalorieApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(d => d.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Repositories
builder.Services.AddTransient<IFoodRepository<Food>, FoodRepository>();

//Services
builder.Services.AddTransient<IFoodService, FoodService>();

//Controller
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
