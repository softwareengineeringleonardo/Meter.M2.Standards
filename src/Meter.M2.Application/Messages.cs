using MediatR;

namespace Meter.M2.Application;

// Command
public record CreateCustomerCommand(string Name, string Email) : IRequest<string>;

// Query
public record GetCustomerByIdQuery(string Id) : IRequest<CustomerDto>;

// DTO
public record CustomerDto(string Id, string Name, string Email);

// Domain Event
public record CustomerCreatedEvent(string CustomerId, string Name, string Email) : INotification;
