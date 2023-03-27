
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Entities.Models
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly EntitiesDbContext _entitiesDbContext;
        public CategoryRepository(EntitiesDbContext entitiesDbContext)
        {
            _entitiesDbContext = entitiesDbContext;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _entitiesDbContext.Categories;
            }
        }

    }
}
