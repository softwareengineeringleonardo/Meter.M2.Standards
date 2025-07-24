using MediatR;

namespace Meter.M2.Application.EventHandler;

public class CustomerCreatedEventHandler : INotificationHandler<CustomerCreatedEvent>
{
    public System.Threading.Tasks.Task Handle(CustomerCreatedEvent notification, System.Threading.CancellationToken ct)
    {
        Console.WriteLine($"[Event] Customer created: {notification.CustomerId}");
        return System.Threading.Tasks.Task.CompletedTask;
    }
}
