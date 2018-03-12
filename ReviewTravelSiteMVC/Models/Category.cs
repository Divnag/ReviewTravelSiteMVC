using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewTravelSiteMVC.Models
{
    public class Category
    {
        [Key]
        [Display (Name="Category")]
        public int CategoryID { get; set; }
        [Display(Name ="Location Category")]
        public string Location { get; set; }
        [Display(Name ="About the Location")]
        public String About { get; set; }

        //Navigation properties
        public virtual ICollection<Review> Reviews { get; set; }

    }
}