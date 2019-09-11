using KitabinBende.Business.Abstract;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.ComplexTypes;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public void Update(Library library)
        {
            throw new NotImplementedException();
        }


        public virtual List<Library> GetByBookID(int bookID)
        {
            return _LibraryDal.GetList(x => x.BookId == bookID);
        }

        public virtual Library GetByID(int libraryID)
        {
            return _LibraryDal.Get(x => x.LibraryId == libraryID);
        }

        public virtual List<Library> GetByUserID(int userID)
        {
            throw new NotImplementedException();
        }

        public virtual List<Library> GetListing(List<Category> categories, int authorId = 0, int publisherId = 0, int languageId = 0, int pageSortId = 0)
        {

            SortOption<IGrouping<Book, Library>, object> _sortOption =
             GetSortOptions().Where(x => x.SortID == pageSortId).FirstOrDefault();

            var retunData = _LibraryDal.GetListWithRelations(x =>
             (x.Book.BookCategory.Any(bc => categories.Select(ci => ci.CategoryId).Contains(bc.CategoryId))
             && (authorId == 0 || x.Book.BookAuthor.Any(ba => ba.AuthorId == authorId))
             && (publisherId == 0 || x.Book.PublisherId == publisherId)
             && (languageId == 0 || x.Book.LanguageId == languageId)
             )).GroupBy(g => g.Book);

            if (_sortOption.isDescending)
            {
                return retunData.OrderByDescending(_sortOption.SortFunc).Select(x => x.FirstOrDefault()).ToList();
            }
            else
            {
                return retunData.OrderBy(_sortOption.SortFunc).Select(x => x.FirstOrDefault()).ToList();
            }
        }

        public virtual List<SortOption<IGrouping<Book, Library>, object>> GetSortOptions()
        {

            List<SortOption<IGrouping<Book, Library>, object>> returnData =
                new List<SortOption<IGrouping<Book, Library>, object>>();

            returnData.Add(new SortOption<IGrouping<Book, Library>, object>
            {
                SortID = 0,
                SortName = "Yeni",
                isDescending = false,
                SortFunc = x => x.Key.FirstPublishYear.Value
            });
            returnData.Add(new SortOption<IGrouping<Book, Library>, object>
            {
                SortID = 1,
                SortName = "A-Z",
                isDescending = false,
                SortFunc = x => x.Key.BookName
            });
            returnData.Add(new SortOption<IGrouping<Book, Library>, object>
            {
                SortID = 2,
                SortName = "Z-A",
                isDescending = true,
                SortFunc = x => x.Key.BookName
            });
            //returnData.Add(new SortOption<IGrouping<Book, Library>, object>
            //{
            //    SortID = 3,
            //    SortName = "En Beğenilen",
            //    isDescending = false,
            //    SortFunc = x => x.Key.BookStarPoint.Average(y => y.Point)
            //});


            return returnData;
        }


    }
}
