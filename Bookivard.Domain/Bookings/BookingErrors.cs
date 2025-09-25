using Bookivard.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookivard.Domain.Bookings
{
    public static  class BookingErrors
    {
        public static readonly Error NotFound = new(
            "Booking.NotFound", 
            "The booking with specific identifier was not fould.");
        public static readonly Error Overlap = new(
          "Booking.Overlap",
          "The current booking is overlapping with existing one");
        public static readonly Error NotReserved = new(
            "Booking.NotReserved", 
            "Only bookings with status 'Reserved' can be rejected.");
        public static readonly Error NotConfirmed = new(
            "Booking.NotConfirmed", 
            "Only bookings with status 'Confirmed' can be completed.");
       
        public static readonly Error AlreadyStarted = new(
          "Booking.AlreadyStarted",
          "The booking has already been started.");

    }
}
