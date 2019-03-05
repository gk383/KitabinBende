using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class Language: IEntity
    {
        public Language()
        {
            Book = new HashSet<Book>();
        }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
