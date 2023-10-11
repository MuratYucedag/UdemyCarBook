using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.Mediator.Queries.CarDescriptionQueries;
using UdemyCarBook.Core.Application.Features.Mediator.Results.CarDescriptionResults;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.Mediator.Handlers.CarDescriptionHandlers
{
    public class GetCarDescriptionQueryHandler : IRequestHandler<GetCarDescriptionQuery, List<GetCarDescriptionQueryResult>>
    {
        private readonly CarBookContext _context;
        public GetCarDescriptionQueryHandler(CarBookContext context)
        {
            _context = context;
        }
        public async Task<List<GetCarDescriptionQueryResult>> Handle(GetCarDescriptionQuery request, CancellationToken cancellationToken)
        {
            return await _context.CarDescriptions.Select(x => new GetCarDescriptionQueryResult
            {
                CarDescriptionID = x.CarDescriptionID,
                CarID = x.CarID,
                Description = x.Description
            }).AsNoTracking().ToListAsync();
        }
    }
}
