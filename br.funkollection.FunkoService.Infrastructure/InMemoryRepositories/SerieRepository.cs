using br.funkollection.FunkoService.Domain.Entities;
using br.funkollection.FunkoService.Domain.Repositories;

namespace br.funkollection.FunkoService.Infrastructure.InMemoryRepositories
{
    public class SerieRepository : ISerieRepository<Serie>
    {
        private readonly IList<Serie> serieList;

        public SerieRepository()
        {
            serieList = new List<Serie>();
        }

        public IList<Serie> GetAll()
        {
            return serieList;
        }

        public Serie GetByLabel(string label)
        {
            return serieList.First(s => s.Label == label);
        }

        public Serie Put(Serie serie)
        {
            
            if(serieList.Where(s => s.Id == serie.Id).Any())
            {
                var existingSerie = serieList.First(s => s.Id == serie.Id);
                existingSerie.Label = serie.Label;
            }
           else
            {
                serie.Id = serieList.Count == 0 ? 1 : serieList.Last().Id + 1;
                serieList.Add(serie);
            }
            return serie;
        }
    }
}
