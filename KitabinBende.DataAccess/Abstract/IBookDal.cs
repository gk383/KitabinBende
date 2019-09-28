using KitabinBende.Core.DataAccess;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KitabinBende.DataAccess.Abstract
{
    public interface IBookDal : IEntityRepository<Book>
    {
        //Custom Operations
        Book GetWithRelations(Expression<Func<Book, bool>> filter);
    }
}
