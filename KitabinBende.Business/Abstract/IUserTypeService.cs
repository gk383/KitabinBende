using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface IUserTypeService
    {
        List<AuthorType> GetAll();
        AuthorType GetByID(int authorTypeID);
        void Add(AuthorType authorType);
        void Update(AuthorType authorType);
        void Delete(int authorTypeID);
    }
}
