using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public class GetAboutQueryHandler : IRequestHandler<GetAboutQuery, List<GetAboutQueryResult>>
    {
        private readonly CarBookContext _context;
        public GetAboutQueryHandler(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<GetAboutQueryResult>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
        {
            return await _context.Abouts.Select(x => new GetAboutQueryResult
            {
                AboutID = x.AboutID,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Status = x.Status
            }).ToListAsync();
        }
    }
}
