using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Core.Application.Features.Mediator.Results.CarDescriptionResults;

namespace UdemyCarBook.Core.Application.Features.Mediator.Queries.CarDescriptionQueries
{
    public class GetCarDescriptionQuery:IRequest<List<GetCarDescriptionQueryResult>>
    {
    }
}
