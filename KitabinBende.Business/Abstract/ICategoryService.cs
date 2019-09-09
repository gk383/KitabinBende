﻿using KitabinBende.Entities.ComplexTypes;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetByID(int categoryID);

        Category GetByParentID(int categoryID);

        List<Category> GetCategoryAndAllSubCategoryIds(int categoryID);
        List<Category> GetCategoryAndAllParentCategories(int categoryID);
        

        Dictionary<Category, int> GetCategoriesForList(List<Library> libraryList, int currentCategoryId);
    }
}
