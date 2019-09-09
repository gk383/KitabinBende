using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Entities.ComplexTypes
{
   public class GetAllParentCategoryResult
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategoryId { get; set; }
        public int CategoryLevel { get; set; }
    }
}
