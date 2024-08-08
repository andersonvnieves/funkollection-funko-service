
using br.funkollection.FunkoService.Domain.Commands.PostFunko;
using br.funkollection.FunkoService.Domain.Entities;
using br.funkollection.FunkoService.Domain.Repositories;
using MediatR;

namespace br.funkollection.FunkoService.Domain.Handler
{
    public class PostFunkoHandler : IRequestHandler<PostFunkoRequest, PostFunkoResponse>
    {
        private readonly IFunkoRepository<Funko> _funkoRepository;

        public PostFunkoHandler(IFunkoRepository<Funko> funkoRepository)
        {
            _funkoRepository = funkoRepository;
        }

        public async Task<PostFunkoResponse> Handle(PostFunkoRequest request, CancellationToken cancellationToken)
        {
            //Validation

        }
    }
}
