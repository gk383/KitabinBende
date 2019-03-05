using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class BookAuthor: IEntity
    {
        public int BookAuthorId { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
