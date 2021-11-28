using System.Net;

namespace BookReviewStation.Models
{
    public class BookDetails
    {
        public long BookId { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Publisher { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
        public string Description { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public PhysicalBookDetails PhysicalBookDetails { get; set; }
        public ISBNDetails ISBNDetails { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}