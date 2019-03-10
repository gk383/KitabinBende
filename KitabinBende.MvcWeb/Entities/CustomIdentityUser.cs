using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitabinBende.MvcWeb.Entities
{
    public class CustomIdentityUser: IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte GenderId { get; set; }
        public string PhotoUrl { get; set; }
    }
}
