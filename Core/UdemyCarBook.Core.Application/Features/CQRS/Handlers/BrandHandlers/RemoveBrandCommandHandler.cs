using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.CQRS.Commands.BrandCommands;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler
    {
        private readonly CarBookContext _context;
        public RemoveBrandCommandHandler(CarBookContext context)
        {
            _context = context;
        }
        public void Handle(RemoveBrandCommand command)
        {
            var values = _context.Brands.Find(command.Id);
            _context.Brands.Remove(values);
            _context.SaveChanges();
        }
    }
}
