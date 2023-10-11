using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.Mediator.Queries.AboutQueries;
using UdemyCarBook.Core.Application.Features.Mediator.Results.AboutResults;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler : IRequestHandler<GetAboutByIdQuery, GetAboutByIdQueryResult>
    {
        private readonly CarBookContext _context;
        public GetAboutByIdQueryHandler(CarBookContext context)
        {
            _context = context;
        }
        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Abouts.FindAsync(request.Id);
            return new GetAboutByIdQueryResult
            {
                AboutID = values.AboutID,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                Status = values.Status,
                Title = values.Title
            };
        }
    }
}
