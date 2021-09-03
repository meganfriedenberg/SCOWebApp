using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Camping", Description="All fun camping"},
                new Category{CategoryId=2, CategoryName="Backpacking", Description="Adventurous backpacking"},
                new Category{CategoryId=3, CategoryName="Surfing", Description="Surfing for beginners and intermediates"}
            };
    }
}
