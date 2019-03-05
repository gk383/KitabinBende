using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class AuthorType: IEntity
    {
        public AuthorType()
        {
            Author = new HashSet<Author>();
        }

        public int AuthorTypeId { get; set; }
        public string AuthorTypeName { get; set; }

        public virtual ICollection<Author> Author { get; set; }
    }
}
