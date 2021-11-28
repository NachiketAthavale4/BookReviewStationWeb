namespace BookReviewStation.Web.Controllers
{
    using BookReviewStation.Abstract.Interfaces;
    using BookReviewStation.Web.Helpers;
    using System.Web.Mvc;
    using System.Net;
    using BookReviewStation.Web.Extensions;

    public class BookController : Controller
    {
        private readonly string _resource = "Book";

        private readonly IBookService bookService;
        private readonly IReviewService reviewService;
        private readonly IAuthorService authorService;

        public BookController(IBookService bookService, IReviewService reviewService, IAuthorService authorService)
        {
            this.bookService = bookService;
            this.reviewService = reviewService;
            this.authorService = authorService;
        }

        [HttpGet]
        public ActionResult GetBook(long bookId)
        {
            if (bookId <= 0)
            {
                ViewBag.Resource = this._resource;
                return View(Constants.NotFoundViewName);
            }

            var bookDetail = this.bookService.GetBookByBookId(bookId);

            if (bookDetail.StatusCode == HttpStatusCode.NotFound)
            {
                ViewBag.Resource = this._resource;
                return View(Constants.NotFoundViewName);
            }

            if (bookDetail.StatusCode == HttpStatusCode.InternalServerError)
            {
                ViewBag.Resource = this._resource;
                return View(Constants.InternalServerError);
            }

            var criticsReviewScore = this.reviewService.GetCriticReviewScore(bookId);
            var userReviewScore = this.reviewService.GetUserReviewScore(bookId);

            var authorInfo = this.authorService.GetAuthorInfo(bookId);

            return View(bookDetail.MapToViewModel(criticsReviewScore, userReviewScore, authorInfo));
        }
    }
}