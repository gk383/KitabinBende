using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class Author : IEntity
    {
        public Author()
        {
            BookAuthor = new HashSet<BookAuthor>();
            BookTranslator = new HashSet<BookTranslator>();
        }

        public int AuthorId { get; set; }
        public int AuthorTypeId { get; set; }
        public string AuthorName { get; set; }

        public AuthorType AuthorType { get; set; }
        public ICollection<BookAuthor> BookAuthor { get; set; }
        public ICollection<BookTranslator> BookTranslator { get; set; }
    }
}
