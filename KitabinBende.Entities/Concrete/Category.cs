using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class Category : IEntity
    {
        public Category()
        {
            BookCategory = new HashSet<BookCategory>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<BookCategory> BookCategory { get; set; }
    }
}
