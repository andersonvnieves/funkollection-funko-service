using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Domain.Queries.GetFunkoById
{
    public record GetFunkoByIdRequest : IRequest<GetFunkoByIdResponse>
    {
        public Guid Id { get; set; }

        public GetFunkoByIdRequest()
        {
            
        }

        public GetFunkoByIdRequest(Guid Id)
        {
            this.Id = Id;
        }
    }
}
