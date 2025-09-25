using Bookivard.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookivard.Domain.Bookings
{
    public record PricingDetails(Money priceForPeriod, Money cleningFee, Money amenitiesUpCharge, Money totalPrice);
}
