using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class AuthorType : IEntity
    {
        public AuthorType()
        {
            Author = new HashSet<Author>();
        }

        public int AuthorTypeId { get; set; }
        public string AuthorTypeName { get; set; }

        public ICollection<Author> Author { get; set; }
    }
}
