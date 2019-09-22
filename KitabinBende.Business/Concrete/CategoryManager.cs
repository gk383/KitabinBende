using System;
using System.Collections.Generic;
using System.Text;
using KitabinBende.Business.Abstract;
using KitabinBende.Entities.Concrete;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.ComplexTypes;
using System.Linq;

namespace KitabinBende.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _CategoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }
        public List<Category> GetByLevel(int categoryLevel)
        {
            return _CategoryDal.GetList(x => x.CategoryLevel == categoryLevel);
        }

        public Category GetByID(int categoryID)
        {
            return _CategoryDal.Get(x => x.CategoryId == categoryID);
        }

        public List<Category> GetByParentID(int categoryID)
        {
            return _CategoryDal.GetList(x => x.ParentCategoryId == categoryID);
        }


        public virtual List<Category> GetCategoryAndAllSubCategoryIds(int categoryID)
        {
            Category _MainCategory = _CategoryDal.Get(x => x.CategoryId == categoryID);
            List<Category> _AllSubCategory = new List<Category>();
            if (_MainCategory != null)
            {

                foreach (var itemGetAllSubCategoryLoop in _CategoryDal.GetAllSubCategoryIds(categoryID))
                {
                    _AllSubCategory.Add(_CategoryDal.Get(x => x.CategoryId == itemGetAllSubCategoryLoop.CategoryID));
                }
                _AllSubCategory.Add(_MainCategory);
            }
            return _AllSubCategory;

        }

        public virtual List<Category> GetCategoryAndAllParentCategories(int categoryID)
        {
            Category _MainCategory = _CategoryDal.Get(x => x.CategoryId == categoryID);
            List<Category> _AllParentCategory = new List<Category>();
            if (_MainCategory != null)
            {
                foreach (var itemGetAllParentCategoryLoop in _CategoryDal.GetAllParentCategory(categoryID).OrderBy(x => x.CategoryLevel))
                {
                    _AllParentCategory.Add(_CategoryDal.Get(x => x.CategoryId == itemGetAllParentCategoryLoop.CategoryId));
                }
            }
            return _AllParentCategory;


        }

        public virtual Dictionary<Category, int> GetCategoriesForList(List<Library> libraryList, int currentCategoryId=0)
        {
            int _CategoryLevel = 1;
            if (currentCategoryId!=0)
            {
                Category _CurrentCategory = GetByID(currentCategoryId);
                _CategoryLevel = _CurrentCategory.CategoryLevel + 1;
            }
           
            List<Category> _Categories = new List<Category>();
            Dictionary<Category, int> returnData = new Dictionary<Category, int>();
            List<int> _CategoryIds = new List<int>();
            foreach (var itemLibraryLoop in libraryList)
            {
                foreach (var itemBookCategoryLoop in itemLibraryLoop.Book.BookCategory)
                {

                    GetAllParentCategoryResult _SubLvlCategory = _CategoryDal.GetAllParentCategory(itemBookCategoryLoop.Category.CategoryId)
                        .Where(x => x.CategoryLevel == _CategoryLevel)
                        .FirstOrDefault();

                    if (_SubLvlCategory == null)
                    {
                        _CategoryIds.Add(itemBookCategoryLoop.Category.CategoryId);
                    }
                    else
                    {
                        _CategoryIds.Add(_SubLvlCategory.CategoryId);
                    }

                }
            }
            var _GroupedCategoryIds = _CategoryIds
                .GroupBy(x => x)
                .ToDictionary(g => g.Key, g => g.Count());


            foreach (var itemCategoryIdsLoop in _GroupedCategoryIds)
            {
                returnData.Add(_CategoryDal.Get(x => x.CategoryId == itemCategoryIdsLoop.Key), itemCategoryIdsLoop.Value);
            }

            returnData = returnData.OrderByDescending(x => x.Value).ThenBy(x => x.Key.CategoryName)
                .ToDictionary(x => x.Key, x => x.Value);

            return returnData;
        }

        public List<GetAvailableParentCategoriesResult> GetMainCategoryMenu()
        {
            return _CategoryDal.GetAvailableParentCategories();
        }
    }
}
