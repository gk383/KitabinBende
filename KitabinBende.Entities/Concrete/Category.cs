using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class Category : IEntity
    {

        //public Category()
        //{
        //    this.BookCategory = new HashSet<BookCategory>();
        //    this.Category1 = new HashSet<Category>();
        //}

        //public int CategoryId { get; set; }
        //public string CategoryName { get; set; }
        //public Nullable<int> ParentCategoryId { get; set; }
        //public int CategoryLevel { get; set; }

        ////[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BookCategory> BookCategory { get; set; }
        ////[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Category> Category1 { get; set; }
        //public virtual Category Category2 { get; set; }
        public Category()
        {
            BookCategory = new HashSet<BookCategory>();
            InverseParentCategory = new HashSet<Category>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategoryId { get; set; }
        public int CategoryLevel { get; set; }

        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<BookCategory> BookCategory { get; set; }
        public virtual ICollection<Category> InverseParentCategory { get; set; }
    }
}
