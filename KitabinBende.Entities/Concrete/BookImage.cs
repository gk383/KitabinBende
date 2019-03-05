using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class BookImage: IEntity
    {
        public int BookImageId { get; set; }
        public int BookId { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }
        public bool IsUploadedByUser { get; set; }
        public bool IsActive { get; set; }

        public virtual Book Book { get; set; }
    }
}
