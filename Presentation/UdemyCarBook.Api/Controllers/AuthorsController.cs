using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Core.Application.Features.CQRS.Commands.AuthorCommands;
using UdemyCarBook.Core.Application.Features.CQRS.Handlers.AuthorHandlers;
using UdemyCarBook.Core.Application.Features.CQRS.Queries;
using UdemyCarBook.Core.Application.Features.CQRS.Queries.AuthorQueries;

namespace UdemyCarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly GetAuthorQueryHandler _getAuthorQueryHandler;
        private readonly GetAuthorByIdQueryHandler _getAuthorByIdQueryHandler;
        private readonly CreateAuthorCommandHandler _createAuthorCommandHandler;
        private readonly UpdateAuthorCommandHandler _updateAuthorCommandHandler;
        private readonly RemoveAuthorCommandHandler _removeAuthorCommandHandler;

        public AuthorsController(GetAuthorQueryHandler getAuthorQueryHandler, GetAuthorByIdQueryHandler getAuthorByIdQueryHandler, CreateAuthorCommandHandler createAuthorCommandHandler, UpdateAuthorCommandHandler updateAuthorCommandHandler, RemoveAuthorCommandHandler removeAuthorCommandHandler)
        {
            _getAuthorQueryHandler = getAuthorQueryHandler;
            _getAuthorByIdQueryHandler = getAuthorByIdQueryHandler;
            _createAuthorCommandHandler = createAuthorCommandHandler;
            _updateAuthorCommandHandler = updateAuthorCommandHandler;
            _removeAuthorCommandHandler = removeAuthorCommandHandler;
        }

        [HttpGet]
        public IActionResult AuthorList()
        {
            var values = _getAuthorQueryHandler.Handle();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAuthor(CreateAuthorCommand command)
        {
            _createAuthorCommandHandler.Handle(command);
            return Ok("Yazar Eklendi");
        }
        [HttpDelete]
        public IActionResult RemoveAuthor(int id)
        {
            _removeAuthorCommandHandler.Handle(new RemoveAuthorCommand(id));
            return Ok("Yazar Silindi");
        }
        [HttpPut]
        public IActionResult UpdateAuthor(UpdateAuthorCommand command)
        {
            _updateAuthorCommandHandler.Handle(command);
            return Ok("Yazar Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var value = _getAuthorByIdQueryHandler.Handle(new GetAuthorByIdQuery(id));
            return Ok(value);
        }
    }
}
