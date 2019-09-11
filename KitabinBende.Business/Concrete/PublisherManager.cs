using KitabinBende.Business.Abstract;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitabinBende.Business.Concrete
{
   public class PublisherManager : IPublisherService
    {
        private IPublisherDal _PublisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            _PublisherDal = publisherDal;
        }

        public void Add(Publisher publisher)
        {
            throw new NotImplementedException();
        }

        public List<Publisher> GetAll()
        {
            throw new NotImplementedException();
        }

        public Publisher GetByID(int publisherID)
        {
            throw new NotImplementedException();
        }


        public virtual Dictionary<Publisher, int> GetPublisherForList(List<Library> libraryList)
        {
            List<Publisher> _Publishers = new List<Publisher>();
            Dictionary<Publisher, int> returnData = new Dictionary<Publisher, int>();
            foreach (var itemLibraryLoop in libraryList)
            {
                _Publishers.Add(itemLibraryLoop.Book.Publisher);
            }

            returnData = _Publishers.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            return returnData;
        }
    }
}
