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

                return filter == null
                    ? db.Set<Library>()
                    .Include(x => x.Book)
                    .Include(x => x.Book.BookAuthor).ThenInclude(y=>y.Author)
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
                    //.Where(x => x.Book.BookCategory.Any(bc => new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Contains(bc.CategoryId)))
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
    }
}
