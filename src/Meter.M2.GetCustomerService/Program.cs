using Microsoft.OpenApi.Models;
using Meter.M2.Infrastructure.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", @{ Title = "GetCustomerService"; Version = "v1" });
});
builder.Services.AddMeterM2Infrastructure();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
