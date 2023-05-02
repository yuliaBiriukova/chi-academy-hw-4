using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace HW_4.Data.Models
{
    public class ASPDeveloper
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Enter name")]
        [Required(ErrorMessage = "Required field")]
        public string name { get; set; }

        [Display(Name = "Enter email")]
        [Required(ErrorMessage = "Required field")]
        public string email { get; set; }
    }
}