using br.funkollection.FunkoService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Domain.Queries.GetFunkoById
{
    public record GetFunkoByIdResponse
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string ImageUrl { get; init; }
        public string Category { get; init; }
        public string Serie { get; init; }
    }
}
