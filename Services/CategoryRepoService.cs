using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pulp.Models;

namespace Pulp.Services
{
    public class CategoryTypeRepoService : ICategoryTypeRepoService
    {
        private readonly myContext context;
        public CategoryTypeRepoService(myContext context)
        {
            this.context = context;
        }
        public int? GetBusinessID(int? CategoryTypeID)
        {
            return context.CategoryTypes.FirstOrDefault(c => c.CatrgoryTypeID == CategoryTypeID).BusinessID;
        }
        public bool CategoryTypeExists(int id)
        {
            return context.CategoryTypes.Any(c => c.CatrgoryTypeID == id);

        }

        public void DeleteCategoryType(int id)
        {
            context.Remove(context.CategoryTypes.FirstOrDefault(c => c.CatrgoryTypeID == id));
            context.SaveChanges();
        }

        public List<CategoryType> GetAllCategoryTypes()
        {
            return context.CategoryTypes.ToList();
        }

        public List<CategoryType> GetAllCategoryTypesOfResID(int? resID)
        {

            return context.CategoryTypes.Include(ct => ct.CategoryItems).Where(c => c.BusinessID == resID).ToList();
        }

        public CategoryType GetDetails(int? id)
        {
            return context.CategoryTypes.FirstOrDefault(r => r.CatrgoryTypeID == id);
        }

        public void Insert(CategoryType categoryType)
        {
            context.CategoryTypes.Add(categoryType);
            context.SaveChanges();
        }

        public void UpdateCategoryType(int id, CategoryType categoryType)
        {
            CategoryType CategoryTypeUpdated = context.CategoryTypes.FirstOrDefault(o => o.CatrgoryTypeID == id);
            CategoryTypeUpdated.Type = categoryType.Type;
            CategoryTypeUpdated.BusinessID = categoryType.BusinessID;

            context.SaveChanges();
        }
    }
}
