using KitabinBende.Entities.ComplexTypes;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitabinBende.Business.Abstract
{
   public interface ILibraryService
    {
        List<Library> GetByUserID(int userID);
        List<Library> GetByBookID(int bookID);
        Library GetByID(int libraryID);
        List<Library> GetListing(List<Category> categories=null, int authorId=0,int publisherId=0,int languageId=0, int pageSort=0);
        List<SortOption<IGrouping<Book, Library>, object>> GetSortOptions();

        void Add(Library library);
        void Update(Library library);
        void Delete(Library library);
    }
}
