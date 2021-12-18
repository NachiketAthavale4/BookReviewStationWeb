using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Web;

namespace BookReviewStation.Models
{
    public class BookDetails
    {
        public long BookId { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string Publisher { get; set; }
        [Display(Name = "Book Cover")]
        public HttpPostedFileBase BookCover { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
        public string Description { get; set; }
        [Display(Name = "Country")]
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