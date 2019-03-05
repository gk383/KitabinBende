using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface ICityService
    {
        List<City> GetAll();
        City GetByID(int cityID);
    }
}
