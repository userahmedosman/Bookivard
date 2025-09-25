using Bookivard.Domain.Abstractions;

namespace Bookivard.Domain.Bookings.Event
{
    public sealed record BookingConfirmedDomainEvent(Guid bookingId) : IDomainEvent;
}