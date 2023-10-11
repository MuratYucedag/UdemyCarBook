using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Application.Features.CQRS.Results.AuthorResults
{
    public class GetAuthorQueryResult
    {
        public int AuthorID { get; set; }
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
