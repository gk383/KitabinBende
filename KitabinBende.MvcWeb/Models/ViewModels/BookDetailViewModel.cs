using System.Collections.Generic;
using KitabinBende.Entities.Concrete;

namespace KitabinBende.MvcWeb.Models.ViewModels
{
    public class BookDetailViewModel
    {
        public Book Book { get; internal set; }
        public List<Book> NewBooks { get; internal set; }
    }
}