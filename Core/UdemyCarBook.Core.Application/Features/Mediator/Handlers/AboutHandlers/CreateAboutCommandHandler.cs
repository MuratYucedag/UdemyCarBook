using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.Mediator.Commands.AboutCommands;
using UdemyCarBook.Core.Domain.Entities;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand>
    {
        private readonly CarBookContext _context;
        public CreateAboutCommandHandler(CarBookContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            _context.Abouts.Add(new About
            {
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Status = request.Status,
                Title = request.Title,
            });
            await _context.SaveChangesAsync();
        }
    }
}
