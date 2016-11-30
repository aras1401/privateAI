using System.ComponentModel.DataAnnotations;

namespace AI_Lib.Models
{
    [MetadataType(typeof(PublisherHelper))]
    public partial class publisher
    {
         
    }

    public class PublisherHelper
    {

        [Display(Name = "Wydawnictwo")]
        public string publisher_name { get; set; }
    }
}