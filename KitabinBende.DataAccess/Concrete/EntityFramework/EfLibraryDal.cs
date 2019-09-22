using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using KitabinBende.Core.DataAccess.EntityFramework;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KitabinBende.DataAccess.Concrete.EntityFramework
{
    public class EfLibraryDal : EfEntityRepositoryBase<Library, KitabinBendeDbContext>, ILibraryDal
    {
        public List<Library> GetListWithRelations(Expression<Func<Library, bool>> filter = null)
        {
            using (var db = new KitabinBendeDbContext())
            {
                //needs to be refactored due to speed isue (category many to may relation makes it slower)
                return filter == null
                    ? db.Set<Library>()
                    .Include(x => x.Book)
                    .Include(x => x.Book.BookAuthor).ThenInclude(y => y.Author)
                    .Include(x => x.Book.BookCategory).ThenInclude(y => y.Category)
                    .Include(x => x.Book.BookComment)
                    .Include(x => x.Book.BookImage)
                    .Include(x => x.Book.BookStarPoint)
                    .Include(x => x.Book.BookTranslator).ThenInclude(y => y.Author)
                    .Include(x => x.Book.Language)
                    .Include(x => x.Book.Publisher)
                    //.GroupBy(g => g.Book).Select(x=>x.FirstOrDefault())
                    .ToList()
                    : db.Set<Library>()
                    .Where(filter)
                    //.GroupBy(g => g.Book).Select(x => x.FirstOrDefault())
                    .Include(x => x.Book)
                    .Include(x => x.Book.BookAuthor).ThenInclude(y => y.Author)
                    .Include(x => x.Book.BookCategory).ThenInclude(y => y.Category)
                    .Include(x => x.Book.BookComment)
                    .Include(x => x.Book.BookImage)
                    .Include(x => x.Book.BookStarPoint)
                    .Include(x => x.Book.BookTranslator).ThenInclude(y => y.Author)
                    .Include(x => x.Book.Language)
                    .Include(x => x.Book.Publisher)
                    .ToList();
            }

        }

        public List<Book> GetSuggestedtWithRelations(Expression<Func<Book, object>> sort, int take, Expression<Func<Book, bool>> filter = null)
        {
            using (var db = new KitabinBendeDbContext())
            {
                return filter == null
                    ? db.Library.Select(x => x.Book).Distinct()
                    .OrderByDescending(sort).Take(take)
                     .Include(x => x.BookAuthor).ThenInclude(y => y.Author)
                     .Include(x => x.BookCategory).ThenInclude(y => y.Category)
                     .Include(x => x.BookComment)
                     .Include(x => x.BookImage)
                     .Include(x => x.BookStarPoint)
                     .Include(x => x.BookTranslator).ThenInclude(y => y.Author)
                     .Include(x => x.Language)
                     .Include(x => x.Publisher).ToList()
                     :
                      db.Library.Select(x => x.Book).Distinct().Where(filter)
                      .OrderByDescending(sort)
                      .Take(take)
                     .Include(x => x.BookAuthor).ThenInclude(y => y.Author)
                     .Include(x => x.BookCategory).ThenInclude(y => y.Category)
                     .Include(x => x.BookComment)
                     .Include(x => x.BookImage)
                     .Include(x => x.BookStarPoint)
                     .Include(x => x.BookTranslator).ThenInclude(y => y.Author)
                     .Include(x => x.Language)
                     .Include(x => x.Publisher).ToList();

            }

        }
    }
}
