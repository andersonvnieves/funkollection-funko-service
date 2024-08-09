using br.funkollection.FunkoService.Domain.Entities;
using br.funkollection.FunkoService.Domain.Queries.GetFunkos;
using br.funkollection.FunkoService.Domain.Repositories;
using MediatR;

namespace br.funkollection.FunkoService.Domain.Handler
{
    public class GetFunkosHandler : IRequestHandler<GetFunkosRequest, GetFunkosResponse>
    {
        private readonly IFunkoRepository<Funko> _funkoRepository;

        public GetFunkosHandler(IFunkoRepository<Funko> funkoRepository)
        {
            _funkoRepository = funkoRepository;
        }
        
        async Task<GetFunkosResponse> IRequestHandler<GetFunkosRequest, GetFunkosResponse>.Handle(GetFunkosRequest request, CancellationToken cancellationToken)
        {
            return new GetFunkosResponse() { items = _funkoRepository.GetAll() };
        }
    }
}
