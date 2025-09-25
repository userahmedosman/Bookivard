using Bookivard.Domain.Abstractions;

namespace Bookivard.Domain.Bookings.Event
{
    public sealed record BookingCompletedDomainEvent(Guid bookingId) : IDomainEvent;
}