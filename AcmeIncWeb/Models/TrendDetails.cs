using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeIncWeb.Models
{
    public class TrendDetails
    {
        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Display(Name = "Category")]
        public int CatId { get; set; }
    }
}
