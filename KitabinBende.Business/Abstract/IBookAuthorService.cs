using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface IBookAuthorService
    {
        List<BookAuthor> GetByBookID(int bookID);
        List<BookAuthor> GetByAuthorID(int authorID);
        void Add(BookAuthor bookAuthor);
        void Delete(BookAuthor bookAuthor);
    }
}
