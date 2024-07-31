using br.funkollection.FunkoService.Domain.Queries.GetFunkoById;
using MediatR;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Domain.Handler
{
    public class GetFunkoByIdQueryHandler : IRequestHandler<GetFunkoByIdRequest, GetFunkoByIdResponse>
    {
        public Task<GetFunkoByIdResponse> Handle(GetFunkoByIdRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
