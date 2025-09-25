using Bookivard.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookivard.Domain.Users.Events
{
    public record UserCreateDomainEvent(Guid userId) : IDomainEvent;
}
