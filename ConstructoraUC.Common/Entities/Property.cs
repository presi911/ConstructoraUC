using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConstructoraUC.Common.Entities
{
    public class Property
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The filed {0} must contain less than {1} characteres.")]
        [Required]
        [Display(Name = "Identificador")]
        public String Identificador { get; set; }

        [MaxLength(10, ErrorMessage = "The filed {0} must contain less than {1} characteres.")]
        [Required]
        [Display(Name = "Value")]
        public double Value { get; set; }

        [JsonIgnore]
        [NotMapped]
        public int IdBlock { get; set; }

    }
}
