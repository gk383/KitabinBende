using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class Publisher: IEntity
    {
        public Publisher()
        {
            Book = new HashSet<Book>();
        }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
