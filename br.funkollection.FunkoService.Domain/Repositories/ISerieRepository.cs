using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Domain.Repositories
{
    public interface ISerieRepository<Serie>
    {
        Serie GetByLabel(string label);
        Serie Put(Serie serie);
        IList<Serie> GetAll();

    }
}
