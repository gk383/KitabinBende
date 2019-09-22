using KitabinBende.Core.DataAccess;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KitabinBende.DataAccess.Abstract
{
    public interface ILibraryDal : IEntityRepository<Library>
    {
        //Custom Operations
        List<Library> GetListWithRelations(Expression<Func<Library, bool>> filter = null);
        List<Book> GetSuggestedtWithRelations(Expression<Func<Book, object>> sort, int take, Expression<Func<Book, bool>> filter = null);
    }
   
}
