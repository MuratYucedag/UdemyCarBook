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
    public class GetBlogWithAuthorQueryHandler : IRequestHandler<GetBlogWithAuthorQuery, List<GetBlogWithAuthorQueryResult>>
    {
        private readonly CarBookContext _context;
        public GetBlogWithAuthorQueryHandler(CarBookContext context)
        {
            _context = context;
        }
        public async Task<List<GetBlogWithAuthorQueryResult>> Handle(GetBlogWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Blogs.Include(x => x.Author).Select(y => new GetBlogWithAuthorQueryResult
            {
                AuthorID = y.AuthorID,
                BlogID = y.BlogID,
                CoverImage = y.CoverImage,
                CreatedDate = y.CreatedDate,
                Title = y.Title,
                NameSurname = y.Author.NameSurname
            }).ToListAsync();
            return values;
        }
    }
}
