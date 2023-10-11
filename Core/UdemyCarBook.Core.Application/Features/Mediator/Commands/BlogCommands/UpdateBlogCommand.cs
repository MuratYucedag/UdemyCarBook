using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Application.Features.Mediator.Commands.BlogCommands
{
    public class UpdateBlogCommand:IRequest
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CoverImage { get; set; }
        public int AuthorID { get; set; }
    }
}
