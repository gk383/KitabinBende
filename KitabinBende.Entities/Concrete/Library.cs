using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class Library : IEntity
    {
        public Library()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int LibraryId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public bool IsShareable { get; set; }

        public Book Book { get; set; }
        public AspNetUsers User { get; set; }
        public ICollection<Transaction> Transaction { get; set; }
    }
}
