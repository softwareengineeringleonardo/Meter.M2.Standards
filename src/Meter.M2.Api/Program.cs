using Microsoft.EntityFrameworkCore;
using Meter.M2.Infrastructure;
using Meter.M2.Infrastructure.IoC;
using Meter.M2.Api.Services;
using Meter.M2.Api.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseInMemoryDatabase("DemoDB"));
builder.Services.AddMeterM2Infrastructure();

// registrar serviÃ§os gRPC isolados
builder.Services.AddTransient<CreateCustomerService>();
builder.Services.AddTransient<GetCustomerByIdService>();
builder.Services.AddTransient<SubscribeCustomerCreatedService>();

builder.Services.AddGrpc();

var app = builder.Build();
using(var scope = app.Services.CreateScope())
{
    scope.ServiceProvider.GetRequiredService<AppDbContext>().Database.EnsureCreated();
}

app.MapGrpcService<CustomerController>();
app.Run();
