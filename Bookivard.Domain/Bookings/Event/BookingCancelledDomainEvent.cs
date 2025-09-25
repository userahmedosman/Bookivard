using Bookivard.Domain.Abstractions;

namespace Bookivard.Domain.Bookings.Event
{
    public sealed record BookingCancelledDomainEvent(Guid bookingId) : IDomainEvent;
}