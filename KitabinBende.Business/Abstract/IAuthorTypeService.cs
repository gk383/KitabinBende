using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
   public interface IAuthorTypeService
    {
        List<AuthorType> GetAll();
        AuthorType GetByID(int authorTypeID);       
    }
}
