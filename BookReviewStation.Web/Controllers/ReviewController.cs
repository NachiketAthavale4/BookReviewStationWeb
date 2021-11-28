namespace BookReviewStation.Web.Controllers
{
    using BookReviewStation.Abstract.Interfaces;
    using System.Linq;
    using System.Web.Mvc;

    public class ReviewController : Controller
    {
        private readonly IReviewService reviewService;

        public ReviewController(IReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        [HttpGet]
        public ActionResult GetCriticsReviewsForBook(long bookId, int pageSize = 5, int pageNumber = 1)
        {
            var criticsReviewsList = this.reviewService.GetCriticsReviewsForBook(bookId, pageSize, pageNumber);

            criticsReviewsList = criticsReviewsList.ToList().Skip((pageNumber - 1) * pageSize).Take(pageSize);

            return View(criticsReviewsList);
        }

        public ActionResult GetUserReviewsForBook(long bookId, int pageSize = 5, int pageNumber = 1)
        {
            var userReviewsList = this.reviewService.GetUserReviewsForBook(bookId, pageSize, pageNumber);

            userReviewsList = userReviewsList.ToList().Skip((pageNumber - 1) * pageSize).Take(pageSize);

            return View(userReviewsList);
        }
    }
}