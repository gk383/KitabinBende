using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class UserAddress : IEntity
    {
        public int UserAddressId { get; set; }
        public int UserId { get; set; }
        public string AddressName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public int CityId { get; set; }
        public bool IsActive { get; set; }

        public City City { get; set; }
        public AspNetUsers User { get; set; }
    }
}
