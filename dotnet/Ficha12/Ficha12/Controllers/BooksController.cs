using Ficha12.Models;
using Ficha12.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ficha12.Controllers
{
    public class BooksController : Controller
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

    }
}
