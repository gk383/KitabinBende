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
    }
   
}
