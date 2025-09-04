using BookCatalog.DTOs;
using BookCatalog.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookCatalog.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        private readonly IBookService _service;

        public BooksController(IBookService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var books = _service.GetAll();
            return View(books);
        }

        public ActionResult Details(int id)
        {
            var book = _service.Get(id);
            if (book == null) return NotFound();
            return View(book);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create() => View();

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(BookDTO book)
        {
            if (ModelState.IsValid)
            {
                _service.Add(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            var book = _service.Get(id);
            if (book == null) return NotFound();
            return View(book);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(BookDTO book)
        {
            if (ModelState.IsValid)
            {
                _service.Update(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            var book = _service.Get(id);
            if (book == null) return NotFound();
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}