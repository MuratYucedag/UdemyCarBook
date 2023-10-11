using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.CQRS.Results.AuthorResults;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.CQRS.Handlers.AuthorHandlers
{
    public class GetAuthorQueryHandler
    {
        private readonly CarBookContext _context;
        public GetAuthorQueryHandler(CarBookContext context)
        {
            _context = context;
        }
        public List<GetAuthorQueryResult> Handle()
        {
            var values = _context.Authors.Select(x => new GetAuthorQueryResult
            {
                AuthorID = x.AuthorID,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                NameSurname = x.NameSurname
            }).ToList();
            return values;
        }
    }
}
