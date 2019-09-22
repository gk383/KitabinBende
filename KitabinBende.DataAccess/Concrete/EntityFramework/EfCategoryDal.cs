using KitabinBende.Core.DataAccess.EntityFramework;
using KitabinBende.DataAccess.Abstract;
using KitabinBende.Entities.ComplexTypes;
using KitabinBende.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KitabinBende.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, KitabinBendeDbContext>, ICategoryDal
    {
        public List<GetAllParentCategoryResult> GetAllParentCategory(int categoryID)
        {
            using (KitabinBendeDbContext db = new KitabinBendeDbContext())
            {
                return db.GetAllParentCategory.FromSql("EXECUTE dbo.GetAllParentCategory {0}", categoryID).ToList();

            }
        }

        public List<GetAllSubCategoryIdsResult> GetAllSubCategoryIds(int categoryID)
        {

            using (KitabinBendeDbContext db = new KitabinBendeDbContext())
            {
                return db.GetAllSubCategoryIds.FromSql("EXECUTE dbo.GetAllSubCategoryIds {0}", categoryID).ToList();

            }
           
        }

        public List<GetAvailableParentCategoriesResult> GetAvailableParentCategories()
        {
            using (KitabinBendeDbContext db = new KitabinBendeDbContext())
            {
                return db.GetAvailableParentCategories.FromSql("EXECUTE dbo.GetAvailableParentCategories").ToList();

            }
        }
    }
}
