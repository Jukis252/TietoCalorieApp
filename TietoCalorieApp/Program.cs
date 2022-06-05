using Microsoft.EntityFrameworkCore;
using TietoCalorieApp.Data;
using TietoCalorieApp.Models;
using TietoCalorieApp.Repositories;
using TietoCalorieApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(d => d.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.WithOrigins(new [] {"https://localhost:3000", "http://localhost:3000" })
        .AllowAnyMethod()
        .AllowCredentials()
        .AllowAnyHeader();
}));

builder.Services.AddHttpContextAccessor();

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

app.UseCors("MyPolicy");

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
