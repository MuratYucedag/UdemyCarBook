using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Domain.Entities;

namespace UdemyCarBook.Core.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogQueryResult
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CoverImage { get; set; }
        public int AuthorID { get; set; }
    }
}
