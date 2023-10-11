using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Application.Features.CQRS.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery
    {
        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
