using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class BookStarPoint : IEntity
    {
        public int BookStarPointId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public byte Point { get; set; }
        public bool IsActive { get; set; }

        public Book Book { get; set; }
        public AspNetUsers User { get; set; }
    }
}
