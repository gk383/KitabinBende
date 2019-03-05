using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface IPublisherService
    {
        List<Publisher> GetAll();
        Publisher GetByID(int publisherID);
        void Add(Publisher publisher);
    }
}
