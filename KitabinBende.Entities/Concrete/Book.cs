using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class Book: IEntity
    {
        public Book()
        {
            BookAuthor = new HashSet<BookAuthor>();
            BookComment = new HashSet<BookComment>();
            BookImage = new HashSet<BookImage>();
            BookStarPoint = new HashSet<BookStarPoint>();
            BookTranslator = new HashSet<BookTranslator>();
            Library = new HashSet<Library>();
        }

        public int BookId { get; set; }
        public int PublisherId { get; set; }
        public int LanguageId { get; set; }
        public int Isbn { get; set; }
        public string BookName { get; set; }
        public int? PageCount { get; set; }
        public string Description { get; set; }
        public byte PointValue { get; set; }

        public virtual Language Language { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
        public virtual ICollection<BookComment> BookComment { get; set; }
        public virtual ICollection<BookImage> BookImage { get; set; }
        public virtual ICollection<BookStarPoint> BookStarPoint { get; set; }
        public virtual ICollection<BookTranslator> BookTranslator { get; set; }
        public virtual ICollection<Library> Library { get; set; }
    }
}
