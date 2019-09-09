using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    public interface IUserService
    {
        AspNetUsers GetByID(int authorTypeID);

        void Add(AspNetUsers user);
        void Update(AspNetUsers user);
        void Delete(AspNetUsers user);
    }
}
