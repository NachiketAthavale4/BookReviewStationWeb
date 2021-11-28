using BookReviewStation.Abstract.Interfaces;
using BookReviewStation.Models;
using System;

namespace BookReviewStation.Service
{
    public class AuthorSeedService : IAuthorService
    {
        public AuthorInfo GetAuthorInfo(long bookId)
        {
            return new AuthorInfo
            {
                AuthorId = 1,
                Name = "George Orwell",
                Description = "George Orwell is one of England's most famous writers and social commentators. Among his works are the classic political satire Animal Farm and the dystopian nightmare vision Nineteen Eighty-Four. Orwell was also a prolific essayist, and it is for these works that he was perhaps best known during his lifetime. They include Why I Write and Politics and the English Language. His writing is at once insightful, poignant and entertaining, and continues to be read widely all over the world."
            };
        }
    }
}