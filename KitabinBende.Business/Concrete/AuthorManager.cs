using KitabinBende.Business.Abstract;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitabinBende.Business.Concrete
{
   public class AuthorManager : IAuthorService
    {
        private IAuthorDal _IAuthorDal;
        public AuthorManager(IAuthorDal authorDal)
        {
            _IAuthorDal = authorDal;
        }
        public void Add(Author author)
        {
            _IAuthorDal.Add(author);
        }

        public void Delete(Author author)
        {
            _IAuthorDal.Delete(author);
        }

        public List<Author> GetAll()
        {
            return _IAuthorDal.GetList();
        }

        public Author GetByID(int authorID)
        {
            return _IAuthorDal.Get(x => x.AuthorId == authorID);
        }

        public List<Author> GetByType(int authorTypeID)
        {
            return _IAuthorDal.GetList(x => x.AuthorTypeId == authorTypeID);
        }

        public void Update(Author author)
        {
            _IAuthorDal.Update(author);
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
    }
}
