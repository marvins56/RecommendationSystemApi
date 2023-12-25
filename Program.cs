using Microsoft.EntityFrameworkCore;
using RecommendationSystemApi.Data;
using RecommendationSystemApi.Services;
using RecommendationSystemApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("Defaultconnection") ?? throw new InvalidOperationException("Connection string 'Defaultconnection' not found.");

builder.Services.AddDbContext<RSDBContext>(options =>
            options.UseSqlServer(connectionString)
           .EnableSensitiveDataLogging(false));
builder.Services.AddScoped<IMovieQueryService, MovieQueryService>();
builder.Services.AddControllers();
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
