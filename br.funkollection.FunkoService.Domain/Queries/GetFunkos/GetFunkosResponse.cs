using br.funkollection.FunkoService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Domain.Queries.GetFunkos
{
    public class GetFunkosResponse
    {
        public IList<Funko> items { get; set; }
    }
}
