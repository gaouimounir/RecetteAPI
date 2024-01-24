using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Database;
using AAMRecetteAPI.Models;
using AAMRecetteAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AAMRecetteAPIContext>(options =>
          options.UseNpgsql(builder.Configuration.GetConnectionString("AAMRecetteAPIContext")));

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services.GetRequiredService<AAMRecetteAPIContext>());
}
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
