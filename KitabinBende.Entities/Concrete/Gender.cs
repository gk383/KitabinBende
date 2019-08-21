using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class Gender : IEntity
    {
        public Gender()
        {
            AspNetUsers = new HashSet<AspNetUsers>();
        }

        public byte GenderId { get; set; }
        public string GenderName { get; set; }

        public ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
