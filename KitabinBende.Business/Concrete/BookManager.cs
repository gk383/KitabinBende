using KitabinBende.Business.Abstract;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Concrete
{
    class BookManager : IBookService
    {
        private IBookDal _IBookDal;

        public BookManager(IBookDal bookDal)
        {
            _IBookDal = bookDal;
        }

        public void Add(Book Book)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book Book)
        {
            throw new NotImplementedException();
        }

        public void Update(Book Book)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetByAuthorID(int authorID)
        {
            throw new NotImplementedException();
        }

        public Book GetByID(int BookID)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetByISBN(int ISBN)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetByLanguageID(int languageID)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetByPublisherID(int publisherID)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetByTranslatorID(int authorID)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetByUserID(int userID)
        {
            throw new NotImplementedException();
        }

       
    }
}
