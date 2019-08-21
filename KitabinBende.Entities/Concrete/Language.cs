using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class Language : IEntity
    {
        public Language()
        {
            Book = new HashSet<Book>();
        }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
