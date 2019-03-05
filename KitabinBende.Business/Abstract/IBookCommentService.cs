using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface IBookCommentService
    {
        List<BookComment> GetAllInactive();

        List<BookComment> GetByBookID(int bookID);
        List<BookComment> GetByUserID(int userID);

        List<BookComment> GetActiveByBookID(int bookID);
        List<BookComment> GetActiveByUserID(int userID);

        List<BookComment> GetInactiveByBookID(int bookID);
        List<BookComment> GetInactiveByUserID(int userID);

        BookComment GetByID(int bookCommentID);

        void Add(BookComment bookComment);
        void Update(BookComment bookComment);
        void Delete(BookComment bookComment);
    }
}
