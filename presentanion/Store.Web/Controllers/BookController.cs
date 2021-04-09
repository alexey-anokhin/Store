using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository bookRepository;
        private int id;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            Book book = bookRepository.GetById(id);
            return View(book);
        }
    }
}
