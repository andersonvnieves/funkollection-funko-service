using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Domain.Entities
{
    public record struct Funko
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string ImageUrl { get; init; }
        public Category Category { get; init; }
        public Serie Serie { get; init; }
        public DateTime CreatedAt { get; init; }
        public DateTime LastModifiedAt { get; init; }
    }
}
