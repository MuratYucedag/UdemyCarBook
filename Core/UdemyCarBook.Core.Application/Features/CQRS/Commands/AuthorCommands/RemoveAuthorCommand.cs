using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Application.Features.CQRS.Commands.AuthorCommands
{
    public class RemoveAuthorCommand
    {
        public RemoveAuthorCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
