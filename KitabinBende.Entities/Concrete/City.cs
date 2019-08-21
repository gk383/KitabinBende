using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class City : IEntity
    {
        public City()
        {
            UserAddress = new HashSet<UserAddress>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public ICollection<UserAddress> UserAddress { get; set; }
    }
}
