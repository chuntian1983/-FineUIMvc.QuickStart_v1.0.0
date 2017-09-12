using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FineUIMvc.QuickStart.Models
{
    public class NewsType
    {
        public int ID { get; set; }

        [Display(Name = "类别名称")]
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string lbname { get; set; }

        [Display(Name = "排序号")]
        [Required]
        public int strord { get; set; }


        [Display(Name = "父id")]
        [Required]
        [StringLength(200)]
        public string parid { get; set; }

        
    }
}