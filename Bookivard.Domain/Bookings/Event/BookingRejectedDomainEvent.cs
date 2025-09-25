using Bookivard.Domain.Abstractions;

namespace Bookivard.Domain.Bookings.Event
{
    public sealed record BookingRejectedDomainEvent(Guid bookingId) : IDomainEvent;
}