using KitabinBende.Core.DataAccess;
using KitabinBende.Entities.ComplexTypes;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom Operations
        List<GetAllSubCategoryIdsResult> GetAllSubCategoryIds(int categoryID);

        List<GetAllParentCategoryResult> GetAllParentCategory(int categoryID);

        List<GetAvailableParentCategoriesResult> GetAvailableParentCategories();
    }
    
}
