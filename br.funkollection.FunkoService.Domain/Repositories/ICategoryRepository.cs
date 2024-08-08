using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Domain.Repositories
{
    public interface ICategoryRepository<Category>
    {
        Category GetByLabel(string label);
        IList<Category> GetAll();
    }
}
