using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebGentel_BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter title of your book")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the auther name")]
        public string Author { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        [Required(ErrorMessage = "Please enter total pages")]
        [Display(Name = "Total pages of book")]
        public int? TotalPages { get; set; }
    }
}
