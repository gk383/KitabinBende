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
                    .Include(x => x.Book.BookAuthor)
                    .Include(x => x.Book.BookCategory)
                    .Include(x => x.Book.BookComment)
                    .Include(x => x.Book.BookImage)
                    .Include(x => x.Book.BookStarPoint)
                    .Include(x => x.Book.BookTranslator)
                    .Include(x => x.Book.Language)
                    .Include(x => x.Book.Publisher)
                    .ToList()
                    : db.Set<Library>().Where(filter)
                    .Include(x => x.Book.BookAuthor)
                    .Include(x => x.Book.BookCategory)
                    .Include(x => x.Book.BookComment)
                    .Include(x => x.Book.BookImage)
                    .Include(x => x.Book.BookStarPoint)
                    .Include(x => x.Book.BookTranslator)
                    .Include(x => x.Book.Language)
                    .Include(x => x.Book.Publisher)
                    .ToList();
            }

        }
    }
}
