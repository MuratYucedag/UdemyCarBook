using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Core.Application.Features.CQRS.Commands.BrandCommands;
using UdemyCarBook.Core.Application.Features.CQRS.Handlers.BrandHandlers;
using UdemyCarBook.Core.Application.Features.CQRS.Queries.BrandQueries;
using UdemyCarBook.Core.Application.Features.CQRS.Results.AuthorResults;

namespace UdemyCarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;

        public BrandsController(GetBrandQueryHandler getBrandQueryHandler, GetBrandByIdQueryHandler getBrandByIdQueryHandler, CreateBrandCommandHandler createBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler, RemoveBrandCommandHandler removeBrandCommandHandler)
        {
            _getBrandQueryHandler = getBrandQueryHandler;
            _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
            _createBrandCommandHandler = createBrandCommandHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
            _removeBrandCommandHandler = removeBrandCommandHandler;
        }

        [HttpGet]
        public IActionResult BrandList()
        {
            return Ok(_getBrandQueryHandler.Handle());
        }

        [HttpPost]
        public IActionResult CreateBrand(CreateBrandCommand command)
        {
            _createBrandCommandHandler.Handle(command);
            return Ok("Yeni Marka Eklendi");
        }

        [HttpDelete]
        public IActionResult RemoveBrand(int id)
        {
            _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
            return Ok("Marka Silindi");
        }

        [HttpPut]
        public IActionResult UpdateBrand(UpdateBrandCommand command)
        {
            _updateBrandCommandHandler.Handle(command);
            return Ok("Marka Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetBrand(int id)
        {
            return Ok(_getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id)));
        }
    }
}
