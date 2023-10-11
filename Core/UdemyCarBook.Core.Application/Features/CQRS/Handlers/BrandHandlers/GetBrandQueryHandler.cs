using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.CQRS.Results.BrandResults;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly CarBookContext _context;
        public GetBrandQueryHandler(CarBookContext context)
        {
            _context = context;
        }
        public List<GetBrandQueryResult> Handle()
        {
            var values = _context.Brands.Select(x => new GetBrandQueryResult
            {
                BrandID = x.BrandID,
                BrandName = x.BrandName,
                Status = x.Status
            }).ToList();
            return values;
        }
    }
}
