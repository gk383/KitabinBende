using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    public interface IBookImageService
    {
        List<BookImage> GetByBookID(int bookID);

        void Add(BookImage bookImage);
        void Delete(BookImage bookImage);
    }
}
