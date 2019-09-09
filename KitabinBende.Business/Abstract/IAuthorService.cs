using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
   public interface IAuthorService
    {
        List<Author> GetAll();
        Author GetByID(int authorID);               
        List<Author> GetByType(int authorTypeID);
        Dictionary<Author, int> GetAuthorForList(List<Library> libraryList);

        void Add(Author author);
        void Update(Author author);
        void Delete(Author author);
    }
}
