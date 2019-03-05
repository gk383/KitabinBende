using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface IBookCommentService
    {
        List<BookComment> GetByBookID(int bookID);
        List<BookComment> GetByUserID(int userID);

        BookComment GetByID(int bookCommentID);

        void Add(BookComment bookComment);
        void Update(BookComment bookComment);
        void Delete(BookComment bookComment);
    }
}
