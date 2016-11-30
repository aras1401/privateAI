using System.ComponentModel.DataAnnotations;

namespace AI_Lib.Models
{
    [MetadataType(typeof(CategoryHelper))]
    public partial class category
    {
         
    }

    public class CategoryHelper
    {

        [Display(Name = "Kategoria")]
        public string category_name { get; set; }
    }
}