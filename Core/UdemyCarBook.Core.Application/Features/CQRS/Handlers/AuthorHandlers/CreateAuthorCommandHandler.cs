using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.CQRS.Commands.AuthorCommands;
using UdemyCarBook.Core.Domain.Entities;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.CQRS.Handlers.AuthorHandlers
{
    public class CreateAuthorCommandHandler
    {
        private readonly CarBookContext _context;
        public CreateAuthorCommandHandler(CarBookContext context)
        {
            _context = context;
        }
        public void Handle(CreateAuthorCommand command)
        {
            _context.Authors.Add(new Author
            {
                Description = command.Description,
                ImageUrl = command.ImageUrl,
                NameSurname = command.NameSurname
            });
            _context.SaveChanges();
        }
    }
}
