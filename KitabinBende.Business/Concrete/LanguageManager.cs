using KitabinBende.Business.Abstract;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KitabinBende.Business.Concrete
{
    public class LanguageManager:ILanguageService
    {
        private ILanguageDal _LanguageDal;

        public LanguageManager(ILanguageDal languageDal)
        {
            _LanguageDal = languageDal;
        }

        public List<Language> GetAll()
        {
            throw new NotImplementedException();
        }

        public Language GetByID(int languageID)
        {
            throw new NotImplementedException();
        }


        public virtual Dictionary<Language, int> GetLanguagesForList(List<Library> libraryList)
        {
            List<Language> _Languages = new List<Language>();
            Dictionary<Language, int> returnData = new Dictionary<Language, int>();
            foreach (var itemLibraryLoop in libraryList)
            {
                _Languages.Add(itemLibraryLoop.Book.Language);
            }

            returnData = _Languages.GroupBy(x => x)
                .ToDictionary(g => g.Key, g => g.Count())
                .OrderByDescending(x => x.Value).ThenBy(x => x.Key.LanguageName)
                .ToDictionary(x => x.Key, x => x.Value);
            return returnData;
        }
    }
}
