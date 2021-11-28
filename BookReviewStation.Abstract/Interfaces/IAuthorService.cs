namespace BookReviewStation.Abstract.Interfaces
{
    using BookReviewStation.Models;

    public interface IAuthorService
    {
        AuthorInfo GetAuthorInfo(long bookId);
    }
}