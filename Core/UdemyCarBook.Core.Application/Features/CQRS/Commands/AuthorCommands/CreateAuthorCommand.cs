using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Application.Features.CQRS.Commands.AuthorCommands
{
    public class CreateAuthorCommand
    {
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
