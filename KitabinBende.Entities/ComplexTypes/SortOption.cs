using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitabinBende.Entities.ComplexTypes
{
   public class SortOption<TSource, TKey>
    {
       
        public int SortID { get; set; }
        public string SortName { get; set; }
        //public Func<IGrouping<Book, Library>,int> SortFunc { get; set; }
        public Func<TSource, TKey> SortFunc { get; set; }
        public bool isDescending { get; set; }
    }
}
