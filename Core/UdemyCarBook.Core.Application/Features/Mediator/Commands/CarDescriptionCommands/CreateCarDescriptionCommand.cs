using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Domain.Entities;

namespace UdemyCarBook.Core.Application.Features.Mediator.Commands.CarDescriptionCommands
{
    public class CreateCarDescriptionCommand:IRequest
    {
        public int CarID { get; set; }
        public string Description { get; set; }
    }
}
