namespace BookReviewStation.Abstract.Interfaces
{
    using BookReviewStation.Models;

    public interface IBookService
    {
        BookDetails GetBookByBookId(long bookId);
        ReviewStatistics GetCriticsReviewStatistics(long bookId);
        ReviewStatistics GetUserReviewStatistics(long bookId);
    }
}