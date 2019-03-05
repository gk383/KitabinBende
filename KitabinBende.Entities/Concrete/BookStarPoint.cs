using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class BookStarPoint: IEntity
    {
        public int BookStarPointId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public byte Point { get; set; }
        public bool IsActive { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
