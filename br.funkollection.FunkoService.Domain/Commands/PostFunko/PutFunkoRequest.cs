using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.funkollection.FunkoService.Domain.Commands.PostFunko
{
    public class PutFunkoRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Serie { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
