using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCOWebApp.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext) //dependency injection since it is registered on the startup class
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
    }
}
