using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface IBookImageService
    {
        List<BookImage> GetAllInactive();
        List<BookImage> GetByBookID(int bookID);
        List<BookImage> GetActiveByBookID(int bookID);
        List<BookImage> GetInactiveByBookID(int bookID);
        void Add(BookImage bookImage);
        void Update(BookImage bookImage);
        void Delete(BookImage bookImage);
    }
}
