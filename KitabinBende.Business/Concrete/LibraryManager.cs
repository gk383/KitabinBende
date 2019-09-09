using KitabinBende.Business.Abstract;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.ComplexTypes;
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

        public List<Library> GetListing(List<Category> categories, int authorId)
        {

            return _LibraryDal.GetListWithRelations(x =>
            (x.Book.BookCategory.Any(bc => categories.Select(ci => ci.CategoryId).Contains(bc.CategoryId))
            &&(authorId == 0 || x.Book.BookAuthor.Any(ba=>ba.AuthorId==authorId))
                    )
                ).GroupBy(g => g.Book).Select(x => x.FirstOrDefault()).ToList();
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
