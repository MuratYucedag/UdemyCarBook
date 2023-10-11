using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.Mediator.Queries.BlogQueries;
using UdemyCarBook.Core.Application.Features.Mediator.Results.BlogResults;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogQueryResult>>
    {
        private readonly CarBookContext _context;
        public GetBlogQueryHandler(CarBookContext context)
        {
            _context = context;
        }
        public async Task<List<GetBlogQueryResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Blogs.Select(x => new GetBlogQueryResult
            {
                AuthorID = x.AuthorID,
                BlogID = x.BlogID,
                CoverImage = x.CoverImage,
                CreatedDate = x.CreatedDate,
                Title = x.Title
            }).ToListAsync();
            return values;
        }
    }
}
