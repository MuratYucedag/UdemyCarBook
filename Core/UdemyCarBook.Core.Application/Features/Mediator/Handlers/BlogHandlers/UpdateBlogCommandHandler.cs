using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.Mediator.Commands.BlogCommands;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly CarBookContext _context;
        public UpdateBlogCommandHandler(CarBookContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Blogs.FindAsync(request.BlogID);
            values.AuthorID = request.AuthorID;
            values.CreatedDate = request.CreatedDate;
            values.CoverImage = request.CoverImage;
            values.Title = request.Title;
            await _context.SaveChangesAsync();
        }
    }
}
