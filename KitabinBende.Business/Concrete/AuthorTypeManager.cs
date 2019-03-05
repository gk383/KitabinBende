using KitabinBende.Business.Abstract;
using KitabinBende.Entities.Concrete;
using KitabinBende.DataAccess.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Concrete
{
   public class AuthorTypeManager : IAuthorTypeService
    {
        private IAuthorTypeDal _IAuthorTypeDal;
        public AuthorTypeManager(IAuthorTypeDal authorTypeDal)
        {
            _IAuthorTypeDal = authorTypeDal;
        }

        public void Add(AuthorType authorType)
        {
            _IAuthorTypeDal.Add(authorType);
        }

        public void Delete(AuthorType authorType)
        {
            _IAuthorTypeDal.Delete(authorType);
        }

        public List<AuthorType> GetAll()
        {
            return _IAuthorTypeDal.GetList();
        }

        public AuthorType GetByID(int authorTypeID)
        {
            return _IAuthorTypeDal.Get(x => x.AuthorTypeId == authorTypeID);
        }

        public void Update(AuthorType authorType)
        {
            _IAuthorTypeDal.Update(authorType);
        }
    }
}
