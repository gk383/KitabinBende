using KitabinBende.Entities.ComplexTypes;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetByLevel(int categoryLevel);
        Category GetByID(int categoryID);
        List<Category> GetByParentID(int categoryID);

        List<Category> GetCategoryAndAllSubCategoryIds(int categoryID);
        List<Category> GetCategoryAndAllParentCategories(int categoryID);       
        Dictionary<Category, int> GetCategoriesForList(List<Library> libraryList, int currentCategoryId=0);
    }
}
