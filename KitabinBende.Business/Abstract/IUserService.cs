using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface IUserService
    {
        User GetByID(int authorTypeID);

        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
