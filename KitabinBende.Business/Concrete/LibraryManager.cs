using KitabinBende.Business.Abstract;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public Library GetByID(int libraryID)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetByUserID(int userID)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetListing()
        {
           return _LibraryDal.GetListWithRelations();
            
        }

        public void Update(Library library)
        {
            throw new NotImplementedException();
        }
    }
}
