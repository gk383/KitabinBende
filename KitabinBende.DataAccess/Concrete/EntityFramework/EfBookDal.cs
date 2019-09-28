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
    public class EfBookDal : EfEntityRepositoryBase<Book, KitabinBendeDbContext>, IBookDal
    {
        public Book GetWithRelations(Expression<Func<Book, bool>> filter)
        {
            using (var db = new KitabinBendeDbContext())
            {
                return db.Book.Where(filter)
                    .Include(x => x.BookAuthor).ThenInclude(y => y.Author)
                    .Include(x => x.BookCategory).ThenInclude(y => y.Category)
                    .Include(x => x.BookComment).ThenInclude(y => y.User)
                    .Include(x => x.BookImage)
                    .Include(x => x.BookStarPoint)
                    .Include(x => x.BookTranslator).ThenInclude(y => y.Author)
                    .Include(x => x.Language)
                    .Include(x => x.Publisher)
                    .Include(x => x.Library)
                    .FirstOrDefault();
                   
            }
        }
      
    }
}
