using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    public interface IBookTranslatorService
    {
        List<BookTranslator> GetByBookID(int bookID);
        List<BookTranslator> GetByAuthorID(int authorID);
        void Add(BookTranslator bookTranslator);
        void Delete(BookTranslator bookTranslator);
    }
}
