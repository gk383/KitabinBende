using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class City: IEntity
    {
        public City()
        {
            UserAddress = new HashSet<UserAddress>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<UserAddress> UserAddress { get; set; }
    }
}
