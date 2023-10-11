using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.Mediator.Results.AboutResults;

namespace UdemyCarBook.Core.Application.Features.Mediator.Queries.AboutQueries
{
    public class GetAboutByIdQuery : IRequest<GetAboutByIdQueryResult>
    {
        public GetAboutByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
