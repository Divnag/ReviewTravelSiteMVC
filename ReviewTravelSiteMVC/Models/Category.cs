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
        public int CategoryID { get; set; }
        public string Location { get; set; }
        public String About { get; set; }

        //Navigation properties
        public virtual ICollection<Review> Reviews { get; set; }

    }
}