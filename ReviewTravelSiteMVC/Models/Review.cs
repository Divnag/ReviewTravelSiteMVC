using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewTravelSiteMVC.Models
{
    public class Review
    {

            [Key]
             public int ReviewID { get; set; }
             [Display(Name ="Name Of the Reviewer")]
             public string ReviewerName { get; set; }
             [Display (Name="Location")]
             public string ReviewTitle { get; set; }
              [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
             public DateTime ReviewDate { get; set; }
             [Display(Name ="Review")]
            public string ReviewContent { get; set; }
            [Display (Name ="Recommended")]
            public bool IsRecommended { get; set; }

            [ForeignKey("Category")]
            [Display(Name ="Category")]
            public int CategoryID { get; set; }

            //Navigation Properties

            public virtual Category Category { get; set; }



        

    }
}