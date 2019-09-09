using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    public interface IBookStarPointService
    {
        List<BookStarPoint> GetByBookID(int bookID);
        List<BookStarPoint> GetByUserID(int userID);

        BookComment GetByID(int bookCommentID);

        void Add(BookComment bookComment);
        void Update(BookComment bookComment);
        void Delete(BookComment bookComment);
    }
}
