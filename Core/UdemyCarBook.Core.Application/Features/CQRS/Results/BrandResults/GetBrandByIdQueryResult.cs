using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Core.Application.Features.CQRS.Results.BrandResults
{
    public class GetBrandByIdQueryResult
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public bool Status { get; set; }
    }
}
