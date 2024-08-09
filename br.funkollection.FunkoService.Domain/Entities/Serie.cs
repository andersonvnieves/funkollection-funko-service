using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Domain.Entities
{
    public record struct Serie
    {
        public int Id { get; set; }
        public string Label { get; set; }
    }
}
