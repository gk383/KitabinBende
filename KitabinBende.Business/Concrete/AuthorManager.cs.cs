using KitabinBende.Business.Abstract;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
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
    }
}
