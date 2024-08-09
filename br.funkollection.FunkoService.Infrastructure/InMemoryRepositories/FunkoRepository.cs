using br.funkollection.FunkoService.Domain.Entities;
using br.funkollection.FunkoService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Infrastructure.InMemoryRepositories
{
    public class FunkoRepository : IFunkoRepository<Funko>
    {
        private readonly IList<Funko> _items;

        public FunkoRepository()
        {
            _items = new List<Funko>();
        }

        public void Add(Funko funko)
        {
            funko.Id = Guid.NewGuid();
            _items.Add(funko);
        }

        public void Delete(Guid id)
        {
            _items.Remove(GetById(id));
        }

        public IList<Funko> GetAll()
        {
            return _items;
        }

        public Funko GetById(Guid id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Funko funko)
        {
            var updatingFunko = GetById(funko.Id);
            updatingFunko.Name = funko.Name;
            updatingFunko.ImageUrl = funko.ImageUrl;
            updatingFunko.Category = funko.Category;
            updatingFunko.Serie = funko.Serie;
            updatingFunko.CreatedAt = funko.CreatedAt;
            updatingFunko.LastModifiedAt = funko.LastModifiedAt;
        }
    }
}
