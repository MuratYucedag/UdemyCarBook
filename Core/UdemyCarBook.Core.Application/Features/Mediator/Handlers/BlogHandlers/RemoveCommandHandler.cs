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
    public class RemoveCommandHandler : IRequestHandler<RemoveBlogCommand>
    {
        private readonly CarBookContext _context;
        public RemoveCommandHandler(CarBookContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Blogs.FindAsync(request.Id);
            _context.Blogs.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
