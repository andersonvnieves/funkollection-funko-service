using br.funkollection.FunkoService.Domain.Queries.GetFunkoById;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Domain.Commands.PostFunko
{
    public class PostFunkoRequest : IRequest<PostFunkoResponse>
    {
    }
}
