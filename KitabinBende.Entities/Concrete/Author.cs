using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class Author: IEntity
    {
        public Author()
        {
            BookAuthor = new HashSet<BookAuthor>();
            BookTranslator = new HashSet<BookTranslator>();
        }

        public int AuthorId { get; set; }
        public int AuthorTypeId { get; set; }
        public string AuthorName { get; set; }

        public virtual AuthorType AuthorType { get; set; }
        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
        public virtual ICollection<BookTranslator> BookTranslator { get; set; }
    }
}
