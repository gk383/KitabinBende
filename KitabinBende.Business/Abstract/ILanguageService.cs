using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface ILanguageService
    {
        List<Language> GetAll();
        Language GetByID(int languageID);
    }
}
