using MediatR;
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
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly CarBookContext _context;
        public GetBlogByIdQueryHandler(CarBookContext context)
        {
            _context = context;
        }
        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Blogs.FindAsync(request.Id);
            return new GetBlogByIdQueryResult
            {
                AuthorID = values.AuthorID,
                BlogID = values.BlogID,
                CoverImage = values.CoverImage,
                CreatedDate = values.CreatedDate,
                Title = values.Title
            };
        }
    }
}
