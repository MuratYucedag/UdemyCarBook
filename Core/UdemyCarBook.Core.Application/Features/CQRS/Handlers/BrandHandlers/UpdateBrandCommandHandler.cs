using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.CQRS.Commands.BrandCommands;
using UdemyCarBook.Core.Domain.Entities;
using UdemyCarBook.Infrastructure.Persistence.Context;

namespace UdemyCarBook.Core.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler
    {
        private readonly CarBookContext _context;
        public UpdateBrandCommandHandler(CarBookContext context)
        {
            _context = context;
        }
        public void Handle(UpdateBrandCommand command)
        {
            var values = _context.Brands.Find(command.BrandID);
            values.BrandName=command.BrandName;
            values.Status=command.Status;
            _context.SaveChanges();
        }
    }
}
