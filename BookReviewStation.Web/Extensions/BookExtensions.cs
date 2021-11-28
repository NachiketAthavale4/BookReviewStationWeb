namespace BookReviewStation.Web.Extensions
{
    using BookReviewStation.Models;
    using BookReviewStation.Web.Models;

    public static class BookExtensions
    {
        public static BookDetailsViewModel MapToViewModel(
            this BookDetails bookDetails,
            ReviewStatistics criticReviewScore,
            ReviewStatistics userReviewScore,
            AuthorInfo authorInfo)
        {
            return new BookDetailsViewModel
            {
                AuthorName = bookDetails.AuthorName,
                Genre = bookDetails.Genre,
                CountryOfOrigin = bookDetails.CountryOfOrigin,
                Language = bookDetails.Language,
                Publisher = bookDetails.Publisher,
                Name = bookDetails.Name,
                Description = bookDetails.Description,
                BookId = bookDetails.BookId,
                BookWeight = bookDetails.PhysicalBookDetails?.BookWeight,
                Height = bookDetails.PhysicalBookDetails?.Height,
                Width = bookDetails.PhysicalBookDetails?.Width,
                Length = bookDetails.PhysicalBookDetails?.Length,
                NumberOfPages = bookDetails.PhysicalBookDetails?.NumberOfPages,
                ISBN10 = bookDetails.ISBNDetails?.ISBN10,
                ISBN13 = bookDetails.ISBNDetails?.ISBN13,
                ErrorCode = bookDetails.ErrorCode,
                ErrorDescription = bookDetails.ErrorDescription,
                ImageData = bookDetails.ImageData,
                ImageMimeType = bookDetails.ImageMimeType,
                AverageCriticsRating = criticReviewScore == null ? 0 : criticReviewScore.AverageRating,
                NumberOfCriticsReviews = criticReviewScore == null ? 0 : criticReviewScore.NumberOfReviews,
                AverageUserRating = userReviewScore == null ? 0 : userReviewScore.AverageRating,
                NumberOfUserReviews = userReviewScore == null ? 0 : userReviewScore.NumberOfReviews,
                AuthorDescription = authorInfo == null ? string.Empty : authorInfo.Description
            };
        }
    }
}