using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using KitabinBende.Entities.Concrete;

namespace KitabinBende.MvcWeb.Models.ViewModels
{
    public class BookAddViewModel
    {
        [Required(ErrorMessage = "Zorunlu alan.")]
        public int PublisherId { get; set; }
        [Required(ErrorMessage = "Zorunlu alan.")]
        public int LanguageId { get; set; }
        [Required(ErrorMessage = "Zorunlu alan.")]
        public int Isbn { get; set; }
        [Required(ErrorMessage = "Zorunlu alan.")]
        public string BookName { get; set; }
        [Required(ErrorMessage = "Zorunlu alan.")]
        public int? PageCount { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Zorunlu alan.")]
        public ICollection<BookAuthor> BookAuthor { get; set; }
        [Required(ErrorMessage = "Zorunlu alan.")]
        public ICollection<BookCategory> BookCategory { get; set; }
        public ICollection<BookImage> BookImage { get; set; }
        public ICollection<BookTranslator> BookTranslator { get; set; }
      
    }
}
