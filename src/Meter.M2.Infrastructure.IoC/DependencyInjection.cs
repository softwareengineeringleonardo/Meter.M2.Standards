using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Meter.M2.Application;
using Meter.M2.Application.CommandHandler;
using Meter.M2.Application.QueryHandler;
using Meter.M2.Application.EventHandler;
using Meter.M2.Domain;
using Meter.M2.Infrastructure;

namespace Meter.M2.Infrastructure.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddMeterM2Infrastructure(this IServiceCollection services)
    {
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddTransient<IRequestHandler<CreateCustomerCommand, string>, CreateCustomerHandler>();
        services.AddTransient<IRequestHandler<GetCustomerByIdQuery, CustomerDto>, GetCustomerByIdHandler>();
        services.AddTransient<INotificationHandler<CustomerCreatedEvent>, CustomerCreatedEventHandler>();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateCustomerCommand).Assembly));
        return services;
    }
}
