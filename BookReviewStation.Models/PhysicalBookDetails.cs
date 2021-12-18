using System.ComponentModel.DataAnnotations;

namespace BookReviewStation.Models
{
    public class PhysicalBookDetails
    {
        [Display(Name = "Weight")]
        public int BookWeight { get; set; }
        [Display(Name = "Pages")]
        public int NumberOfPages { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
    }
}