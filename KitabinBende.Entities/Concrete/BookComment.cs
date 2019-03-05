using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class BookComment: IEntity
    {
        public int BookCommentId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Header { get; set; }
        public string Detail { get; set; }
        public bool IsActive { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
