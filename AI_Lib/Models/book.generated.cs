//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AI_Lib.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class book
    {
        public int book_id { get; set; }
        public Nullable<int> publisher_id { get; set; }
        public Nullable<int> author_id { get; set; }
        public string book_title { get; set; }
        public string book_original_title { get; set; }
        public Nullable<System.DateTime> book_release_date { get; set; }
        public Nullable<decimal> book_isbn_no { get; set; }
        public Nullable<int> book_page_no { get; set; }
        public Nullable<int> category_id { get; set; }
        public Nullable<int> book_rate { get; set; }
        public string book_cover_url { get; set; }
    
        public virtual author author { get; set; }
        public virtual category category { get; set; }
        public virtual publisher publisher { get; set; }
    }
}
