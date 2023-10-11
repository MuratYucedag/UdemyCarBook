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
    public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand>
    {
        private readonly CarBookContext _context;

        public UpdateAboutCommandHandler(CarBookContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Abouts.FindAsync(request.AboutID);
            values.Description= request.Description;
            values.Status= request.Status;
            values.Title= request.Title;
            values.ImageUrl= request.ImageUrl;
            await _context.SaveChangesAsync();
        }
    }
}
