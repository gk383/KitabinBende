﻿using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class BookAuthor : IEntity
    {
        public int BookAuthorId { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }
        public Book Book { get; set; }
    }
}
