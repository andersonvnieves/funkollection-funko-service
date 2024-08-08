using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Domain.Repositories
{
    public interface IFunkoRepository<Funko>
    {
        Funko GetById(Guid id);
        IList<Funko> GetAll();
        void Add(Funko funko);
        void Update(Funko funko);
        void Delete(Guid id);
    }
}
