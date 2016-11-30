using System;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;

namespace AI_Lib.Models
{
    [MetadataType(typeof(AuthorHelper))]
    public partial class author
    {
         
    }

    public class AuthorHelper
    {
        [Display(Name = "Imię autora")]
        public string author_first_name { get; set; }
        [Display(Name = "Nazwisko autora")]
        public string author_name { get; set; }
        [Display(Name = "Email")]
        [EmailAddress]
        public string author_email { get; set; }
        [Display(Name = "O autorze")]
        public string author_about { get; set; }
        [Display(Name = "Data urodzenia autora"), DataType(DataType.Date)]
        public DateTime author_date_of_birth { get; set; }
        [Display(Name = "Płeć")]
        public string author_gender { get; set; }
        [Display(Name = "Strona autora")]
        [Url]
        public string author_website { get; set; }
    }
}