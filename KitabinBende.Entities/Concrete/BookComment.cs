using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class BookComment : IEntity
    {
        public int BookCommentId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Header { get; set; }
        public string Detail { get; set; }
        public bool IsActive { get; set; }

        public Book Book { get; set; }
        public AspNetUsers User { get; set; }
    }
}
