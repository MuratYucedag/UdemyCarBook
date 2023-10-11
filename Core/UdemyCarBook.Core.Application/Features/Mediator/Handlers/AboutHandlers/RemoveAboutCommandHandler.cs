using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.Mediator.Commands.AboutCommands;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class RemoveAboutCommandHandler : IRequestHandler<RemoveAboutCommand>
    {
        private readonly CarBookContext _context;
        public RemoveAboutCommandHandler(CarBookContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveAboutCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Abouts.FindAsync(request.Id);
            _context.Abouts.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
