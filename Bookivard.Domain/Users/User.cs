using Bookivard.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookivard.Domain.Users
{
    public sealed class User:Entity
    {
        private User(Guid userId, FirstName firstName, LastName lastName, Email email):base (userId)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public FirstName FirstName { get; private set; }
        public LastName LastName { get; private set; }
        public Email Email { get; private set; }

        public static User Create(FirstName firstName, LastName lastName, Email email)
        {
            // Add any necessary validation or business rules here
           var user = new User(Guid.NewGuid(), firstName, lastName, email);
           user.RaiseDomainEvent(new Events.UserCreateDomainEvent(user.Id));
            return user;
        }

    }
}
