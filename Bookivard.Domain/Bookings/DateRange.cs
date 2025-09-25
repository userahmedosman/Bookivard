using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookivard.Domain.Bookings
{
    public record DateRange
    {
        private DateRange()
        {
        }

        public DateOnly Start { get; set; }
        public DateOnly End { get; set; }

        public int LengthInDays => (End.DayNumber - Start.DayNumber);

        public static DateRange Create(DateOnly start, DateOnly end)
        {
            if (end <= start)
            {
                throw new ArgumentException("End date must be after start date");
            }
            return new DateRange
            {
                Start = start,
                End = end
            };
        }
    }
}
