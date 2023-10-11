using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.CQRS.Queries.AuthorQueries;
using UdemyCarBook.Core.Application.Features.CQRS.Results.AuthorResults;
using UdemyCarBook.Core.Domain.Entities;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.CQRS.Handlers.AuthorHandlers
{
    public class GetAuthorByIdQueryHandler
    {
        private readonly CarBookContext _context;
        public GetAuthorByIdQueryHandler(CarBookContext context)
        {
            _context = context;
        }
        public GetAuthorByIdQueryResult Handle(GetAuthorByIdQuery query)
        {
            var values=_context.Set<Author>().Find(query.Id);
            return new GetAuthorByIdQueryResult
            {
                AuthorID = values.AuthorID,
                Description = values.Description,
                ImageUrl = values.ImageUrl,
                NameSurname = values.NameSurname
            };
        }
    }
}