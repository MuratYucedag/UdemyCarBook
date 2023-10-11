using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.CQRS.Commands.AuthorCommands;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.CQRS.Handlers.AuthorHandlers
{
    public class RemoveAuthorCommandHandler
    {
        private readonly CarBookContext _context;
        public RemoveAuthorCommandHandler(CarBookContext context)
        {
            _context = context;
        }
        public void Handle(RemoveAuthorCommand command)
        {
            var value = _context.Authors.Find(command.Id);
            _context.Authors.Remove(value);
            _context.SaveChanges();
        }
    }
}
