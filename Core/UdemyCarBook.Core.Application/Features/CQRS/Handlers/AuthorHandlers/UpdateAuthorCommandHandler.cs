using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.CQRS.Commands.AuthorCommands;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.CQRS.Handlers.AuthorHandlers
{
    public class UpdateAuthorCommandHandler
    {
        private readonly CarBookContext _context;
        public UpdateAuthorCommandHandler(CarBookContext context)
        {
            _context = context;
        }
        public void Handle(UpdateAuthorCommand command)
        {
            var values = _context.Authors.Find(command.AuthorID);
            values.NameSurname = command.NameSurname;
            values.Description= command.Description;
            values.ImageUrl = command.ImageUrl;
            _context.SaveChanges();
        }
    }
}
