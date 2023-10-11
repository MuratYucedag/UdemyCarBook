using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Core.Application.Features.Mediator.Commands.BlogCommands;
using UdemyCarBook.Core.Application.Features.Mediator.Queries.BlogQueries;

namespace UdemyCarBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }

        [HttpGet("BlogListWithAuthor")]
        public async Task<IActionResult> BlogListWithAuthor()
        {
            var values = await _mediator.Send(new GetBlogWithAuthorQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(int id)
        {
            return Ok(await _mediator.Send(new GetBlogByIdQuery(id)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
           await _mediator.Send(command);
            return Ok("Blog Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Blog Başarılı Bir Şekilde Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Başarılı Bir Şekilde Güncellendi");
        }
    }
}
