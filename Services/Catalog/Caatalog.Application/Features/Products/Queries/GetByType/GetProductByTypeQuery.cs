using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Caatalog.Application.Features.Products.Commands.Responses;

namespace Caatalog.Application.Features.Products.Queries.GetByType
{
    public  class GetProductByTypeQuery :IRequest<List<ProductResponse>>
    {
        public string Name { get; set; }
        public GetProductByTypeQuery(string name)
        {
            Name = name;
        }
    }
}