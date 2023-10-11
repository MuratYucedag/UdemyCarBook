using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogWithAuthorQueryResult
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CoverImage { get; set; }
        public int AuthorID { get; set; }
        public string NameSurname { get; set; }
    }
}
