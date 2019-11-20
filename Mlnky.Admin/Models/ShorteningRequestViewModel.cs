using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mlnky.Admin.Models
{
    public class ShorteningRequestViewModel
    {
        [Required(ErrorMessage = "Need to put in a value")]
        [Display(Name = "URL to Shorten")]
        public string LongUrl { get; set; }
    }
}
