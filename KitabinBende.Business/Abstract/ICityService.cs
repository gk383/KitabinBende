using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        City GetByID(int cityID);
    }
}
