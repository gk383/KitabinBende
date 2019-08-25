using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
   public interface ILibraryService
    {
        List<Library> GetByUserID(int userID);
        List<Library> GetByBookID(int bookID);
        Library GetByID(int libraryID);

        List<Library> GetListing();
        Dictionary<Category, int> GetCategoriesForList(List<Library> libraryList);
        Dictionary<Language, int> GetLanguagesForList(List<Library> libraryList);
        Dictionary<Author, int> GetAuthorForList(List<Library> libraryList);
        Dictionary<Publisher, int> GetPublisherForList(List<Library> libraryList);



        void Add(Library library);
        void Update(Library library);
        void Delete(Library library);
    }
}
