
using br.funkollection.FunkoService.Domain.Commands.PostFunko;
using br.funkollection.FunkoService.Domain.Entities;
using br.funkollection.FunkoService.Domain.Repositories;
using MediatR;

namespace br.funkollection.FunkoService.Domain.Handler
{
    public class PostFunkoHandler : IRequestHandler<PostFunkoRequest, PostFunkoResponse>
    {
        private readonly IFunkoRepository<Funko> _funkoRepository;
        private readonly ICategoryRepository<Category> _categoryRepository;
        private readonly ISerieRepository<Serie> _serieRepository;

        public PostFunkoHandler(IFunkoRepository<Funko> funkoRepository, ICategoryRepository<Category> categoryRepository, ISerieRepository<Serie> serieRepository)
        {
            _funkoRepository = funkoRepository;
            _categoryRepository = categoryRepository;
            _serieRepository = serieRepository;
        }

        public async Task<PostFunkoResponse> Handle(PostFunkoRequest request, CancellationToken cancellationToken)
        {
            //Validation
            _funkoRepository.Add(new Funko() { 
                Name = request.Name,
                Category = _categoryRepository.GetByLabel(request.Category),
                Serie = _serieRepository.Put(new Serie() { Label = request.Serie }),
                ImageUrl = request.ImageUrl,
                CreatedAt = DateTime.UtcNow,
            });
            return new PostFunkoResponse();
        }
    }
}
