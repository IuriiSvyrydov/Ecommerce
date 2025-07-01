using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Caatalog.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public string Id { get; set; }

        public DeleteProductCommand(string id)
        {
            Id = id;       
            
        }
    }
}