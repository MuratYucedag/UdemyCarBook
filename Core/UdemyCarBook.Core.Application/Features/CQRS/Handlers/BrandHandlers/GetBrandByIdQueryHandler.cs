using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.CQRS.Queries.BrandQueries;
using UdemyCarBook.Core.Application.Features.CQRS.Results.BrandResults;
using UdemyCarBook.Core.Domain.Entities;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly CarBookContext _context;
        public GetBrandByIdQueryHandler(CarBookContext context)
        {
            _context = context;
        }
        public GetBrandByIdQueryResult Handle(GetBrandByIdQuery query)
        {
            var values = _context.Set<Brand>().Find(query.Id);
            return new GetBrandByIdQueryResult
            {
                BrandID = values.BrandID,
                BrandName = values.BrandName,
                Status = values.Status
            };
        }
    }
}
