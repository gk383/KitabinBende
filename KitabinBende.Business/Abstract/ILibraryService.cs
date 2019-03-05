using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface ILibraryService
    {
        List<Library> GetByUserID(int userID);
        List<Library> GetByBookID(int bookID);
        Library GetByID(int libraryID);

        void Add(Library library);
        void Update(Library library);
        void Delete(Library library);
    }
}
