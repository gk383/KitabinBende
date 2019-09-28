using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetByUserID(int userID);
        List<Book> GetByISBN(int ISBN);
        List<Book> GetByPublisherID(int publisherID);
        List<Book> GetByLanguageID(int languageID);
        List<Book> GetByAuthorID(int authorID);
        List<Book> GetByTranslatorID(int authorID);

        Book GetByID(int BookID);

        Book GetBookDetailByID(int BookID);

        void Add(Book Book);
        void Update(Book Book);
        void Delete(Book Book);
    }
}
