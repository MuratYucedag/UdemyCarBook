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
    public class CreateBrandCommandHandler
    {
        private readonly CarBookContext _context;
        public CreateBrandCommandHandler(CarBookContext context)
        {
            _context = context;
        }
        public void Handle(CreateBrandCommand command)
        {
            _context.Brands.Add(new Brand
            {
                BrandName = command.BrandName,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
