using System;
using System.Collections.Generic;
using System.Text;
using KitabinBende.Core.DataAccess.EntityFramework;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.Concrete;

namespace KitabinBende.DataAccess.Concrete.EntityFramework
{
    public class EfBookAuthorDal : EfEntityRepositoryBase<BookAuthor, KitabinBendeDbContext>, IBookAuthorDal
    {
    }
}
