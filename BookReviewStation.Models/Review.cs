namespace BookReviewStation.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Net;

    public class Review
    {
        public long ReviewId { get; set; }
        public long BookId { get; set; }
        public ReviewType Type { get; set; }
        public string ReviewDescription { get; set; }
        public string ReviewTitle { get; set; }

        [Range(1.0, 5.0)]
        public double Rating { get; set; }
        public string ReviewingOrganization { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewLink { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}