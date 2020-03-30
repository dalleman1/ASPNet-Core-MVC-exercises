using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNet_Core_MVC.Data
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        [Required]
        [Display(Name = "Name:")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Email:")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Experience:")]
        public string experince { get; set; }
    }
}
