using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.Mediator.Results.CarDescriptionResults;

namespace UdemyCarBook.Core.Application.Features.Mediator.Queries.CarDescriptionQueries
{
    public class GetCarDescriptionByIdQuery:IRequest<GetCarDescriptionByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCarDescriptionByIdQuery(int id)
        {
            Id = id;
        }
    }
}
