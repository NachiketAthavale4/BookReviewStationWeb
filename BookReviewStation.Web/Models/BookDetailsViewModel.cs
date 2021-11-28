namespace BookReviewStation.Web.Models
{
    public class BookDetailsViewModel
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
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public int? BookWeight { get; set; }
        public int? NumberOfPages { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public int? Length { get; set; }
        public string ISBN10 { get; set; }
        public string ISBN13 { get; set; }
        public long NumberOfCriticsReviews { get; set; }
        public double AverageCriticsRating { get; set; }
        public long NumberOfUserReviews { get; set; }
        public double AverageUserRating { get; set; }
        public string AuthorDescription { get; set; }
        public byte[] AuthorImageData { get; set; }
        public string AuthorImageMimeType { get; set; }
    }
}