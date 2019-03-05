using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface IBookStarPointService
    {
        List<BookStarPoint> GetAllInactive();

        List<BookStarPoint> GetByBookID(int bookID);
        List<BookStarPoint> GetByUserID(int userID);

        List<BookStarPoint> GetActiveByBookID(int bookID);
        List<BookStarPoint> GetActiveByUserID(int userID);

        List<BookStarPoint> GetInactiveByBookID(int bookID);
        List<BookStarPoint> GetInactiveByUserID(int userID);

        BookComment GetByID(int bookCommentID);

        void Add(BookComment bookComment);
        void Update(BookComment bookComment);
        void Delete(BookComment bookComment);
    }
}
