using br.funkollection.FunkoService.Domain.Entities;
using br.funkollection.FunkoService.Domain.Queries.GetFunkoById;
using br.funkollection.FunkoService.Domain.Repositories;
using MediatR;

namespace br.funkollection.FunkoService.Domain.Handler
{
    public class GetFunkoByIdQueryHandler : IRequestHandler<GetFunkoByIdRequest, GetFunkoByIdResponse>
    {
        private readonly IFunkoRepository<Funko> _funkoRepository;

        public GetFunkoByIdQueryHandler(IFunkoRepository<Funko> funkoRepository)
        {
            _funkoRepository = funkoRepository;
        }

        public async Task<GetFunkoByIdResponse> Handle(GetFunkoByIdRequest request, CancellationToken cancellationToken)
        {
            //Validation
            var funko = _funkoRepository.GetById(request.Id);
            return new GetFunkoByIdResponse() { 
                Id = funko.Id,
                Name = funko.Name,
                ImageUrl = funko.ImageUrl,
                Category = funko.Category.Label,
                Serie = funko.Serie.Label
            };
        }
    }
}
