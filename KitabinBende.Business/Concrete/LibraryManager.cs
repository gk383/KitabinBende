using KitabinBende.Business.Abstract;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitabinBende.Business.Concrete
{
    public class LibraryManager : ILibraryService
    {
        private ILibraryDal _LibraryDal;
        public LibraryManager(ILibraryDal libraryDal)
        {
            _LibraryDal = libraryDal;
        }

        public void Add(Library library)
        {
            throw new NotImplementedException();
        }

        public void Delete(Library library)
        {
            throw new NotImplementedException();
        }

        public Dictionary<Author, int> GetAuthorForList(List<Library> libraryList)
        {
            List<Author> _Authors = new List<Author>();
            Dictionary<Author, int> returnData = new Dictionary<Author, int>();
            foreach (var itemLibraryLoop in libraryList)
            {
                foreach (var itemBookAuthorLoop in itemLibraryLoop.Book.BookAuthor)
                {
                    _Authors.Add(itemBookAuthorLoop.Author);
                }
            }

            returnData = _Authors.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            return returnData;
        }

        public List<Library> GetByBookID(int bookID)
        {
            return _LibraryDal.GetList(x => x.BookId == bookID);
        }

        public Library GetByID(int libraryID)
        {
            return _LibraryDal.Get(x => x.LibraryId == libraryID);
        }

        public List<Library> GetByUserID(int userID)
        {
            throw new NotImplementedException();
        }

        public Dictionary<Category, int> GetCategoriesForList(List<Library> libraryList)
        {
            List<Category> _Categories = new List<Category>();
            Dictionary<Category, int> returnData = new Dictionary<Category, int>();
            foreach (var itemLibraryLoop in libraryList)
            {
                foreach (var itemBookCategoryLoop in itemLibraryLoop.Book.BookCategory)
                {
                    _Categories.Add(itemBookCategoryLoop.Category);
                }
            }

            returnData = _Categories.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            return returnData;
        }

        public Dictionary<Language, int> GetLanguagesForList(List<Library> libraryList)
        {
            List<Language> _Languages = new List<Language>();
            Dictionary<Language, int> returnData = new Dictionary<Language, int>();
            foreach (var itemLibraryLoop in libraryList)
            {
                _Languages.Add(itemLibraryLoop.Book.Language);
            }

            returnData = _Languages.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            return returnData;
        }

        public List<Library> GetListing()
        {
            return _LibraryDal.GetListWithRelations();
        }

        public Dictionary<Publisher, int> GetPublisherForList(List<Library> libraryList)
        {
            List<Publisher> _Publishers = new List<Publisher>();
            Dictionary<Publisher, int> returnData = new Dictionary<Publisher, int>();
            foreach (var itemLibraryLoop in libraryList)
            {
                _Publishers.Add(itemLibraryLoop.Book.Publisher);                
            }

            returnData = _Publishers.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            return returnData;
        }

        public void Update(Library library)
        {
            throw new NotImplementedException();
        }


    }
}
