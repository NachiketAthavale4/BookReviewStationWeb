namespace BookReviewStation.Models
{
    public class AuthorInfo
    {
        public long AuthorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}