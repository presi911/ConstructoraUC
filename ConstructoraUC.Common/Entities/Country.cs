using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructoraUC.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The filed {0} must contain less than {1} characteres.")]
        [Required]
        [Display(Name = "Country")]
        public String Name { get; set; }

    }
}
