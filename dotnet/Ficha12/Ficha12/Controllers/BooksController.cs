using Ficha12.Models;
using Ficha12.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Ficha12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService service;

        public BooksController(IBookService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return service.GetAll();
        }

        [HttpGet("{isbn}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(string isbn)
        {
            var book = service.GetByISBN(isbn);
            return book != null ? Ok(book) : NotFound();
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Book book)
        {
            return Created("", service.Create(book));
        }

        [HttpDelete("{isbn}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(string isbn)
        {
            service.DeleteByISBN(isbn);
            return Ok();
        }

        //TODO query paramether
        [HttpPatch("{isbn, publisherId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Patch(string isbn, int publisherId)
        {
            service.UpdatePublisher(isbn, publisherId);
            return Ok();
        }
    }
}
