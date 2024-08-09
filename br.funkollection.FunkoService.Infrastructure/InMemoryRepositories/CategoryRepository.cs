using br.funkollection.FunkoService.Domain.Entities;
using br.funkollection.FunkoService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Infrastructure.InMemoryRepositories
{
    public class CategoryRepository : ICategoryRepository<Category>
    {
        private readonly IList<Category> _categories;
        public CategoryRepository()
        {
            _categories = new List<Category>();
            _categories.Add(new Category { Id = 1, Label = "POP" });
        }

        public IList<Category> GetAll()
        {
            return _categories;
        }

        public Category GetByLabel(string label)
        {
            return _categories.First(c => c.Label == label);
        }
    }
}
