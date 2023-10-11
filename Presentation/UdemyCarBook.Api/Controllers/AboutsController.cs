using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Core.Application.Features.Mediator.Commands.AboutCommands;
using UdemyCarBook.Core.Application.Features.Mediator.Queries.AboutQueries;

namespace UdemyCarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AboutsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _mediator.Send(new GetAboutQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var values = await _mediator.Send(new GetAboutByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hakkımda Bilgisi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAbout(int id)
        {
            await _mediator.Send(new RemoveAboutCommand(id));
            return Ok("Hakkımda Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
        {
            await _mediator.Send(command);
            return Ok("Hakkımda Bilgisi Güncellendi");
        }
    }
}
