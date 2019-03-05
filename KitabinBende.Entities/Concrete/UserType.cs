using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class UserType: IEntity
    {
        public UserType()
        {
            User = new HashSet<User>();
        }

        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
