using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class Book : IEntity
    {
        public Book()
        {
            BookAuthor = new HashSet<BookAuthor>();
            BookCategory = new HashSet<BookCategory>();
            BookComment = new HashSet<BookComment>();
            BookImage = new HashSet<BookImage>();
            BookStarPoint = new HashSet<BookStarPoint>();
            BookTranslator = new HashSet<BookTranslator>();
            Library = new HashSet<Library>();
        }

        public int BookId { get; set; }
        public int PublisherId { get; set; }
        public int LanguageId { get; set; }
        public string Isbn { get; set; }
        public string BookName { get; set; }
        public int? PageCount { get; set; }
        public string Description { get; set; }
        public byte PointValue { get; set; }

        public Language Language { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<BookAuthor> BookAuthor { get; set; }
        public ICollection<BookCategory> BookCategory { get; set; }
        public ICollection<BookComment> BookComment { get; set; }
        public ICollection<BookImage> BookImage { get; set; }
        public ICollection<BookStarPoint> BookStarPoint { get; set; }
        public ICollection<BookTranslator> BookTranslator { get; set; }
        public ICollection<Library> Library { get; set; }
    }
}
