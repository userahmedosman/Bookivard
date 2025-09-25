using Bookivard.Domain.Abstractions;

namespace Bookivard.Domain.Bookings.Event
{
    public sealed record BookingReservedDomainEvent(Guid bookingId) : IDomainEvent;
}