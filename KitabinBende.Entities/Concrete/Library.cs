using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class Library: IEntity
    {
        public Library()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int LibraryId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
