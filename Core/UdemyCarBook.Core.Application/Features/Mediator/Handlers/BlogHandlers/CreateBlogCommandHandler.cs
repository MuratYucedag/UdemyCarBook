using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.Mediator.Commands.BlogCommands;
using UdemyCarBook.Core.Domain.Entities;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly CarBookContext _context;

        public CreateBlogCommandHandler(CarBookContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            _context.Blogs.Add(new Blog
            {
                AuthorID = request.AuthorID,
                CoverImage = request.CoverImage,
                CreatedDate = request.CreatedDate,
                Title = request.Title,
            });
            await _context.SaveChangesAsync();
        }
    }
}
