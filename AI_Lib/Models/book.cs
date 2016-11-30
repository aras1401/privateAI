using System;
using System.ComponentModel.DataAnnotations;

namespace AI_Lib.Models
{
    [MetadataType(typeof(BookHelper))]
    public partial class book
    {
         
    }

    public class BookHelper
    {
        [Display(Name = "Tytył książki")]
        public string book_title { get; set; }
        [Display(Name = "Oryginalny tytył książki")]
        public string book_original_title { get; set; }
        [Display(Name = "Data wydania książki"), DataType(DataType.Date)]
        public DateTime book_release_date { get; set; }
        [Display(Name = "ISBN")]
        [DisplayFormat(DataFormatString = "{0:F0}")]
        public decimal book_isbn_no { get; set; }
        [Display(Name = "Liczba stron")]
        public int book_page_no { get; set; }
        [Display(Name = "Ocena książki")]
        public int book_rate { get; set; }
        [Display(Name = "Url okładki książki")]
        [Url]
        public string book_cover_url { get; set; }
    }
}