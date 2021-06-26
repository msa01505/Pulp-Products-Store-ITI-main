using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pulp.Models;

namespace Pulp.ViewModels
{
    public class BusinessCategoryType
    {
        public Business business { set; get; }
        public CategoryType categoryType { set; get; }
        public Business cartRest { set; get; }
        public List<CategoryType> categoryTypes { set; get; }
        public List<CategoryItem> categoryItems { set; get; }
        public CategoryItemViewModel CategoryItemViewModel { set; get; }
        public string Flag { set; get; }
    }
}
