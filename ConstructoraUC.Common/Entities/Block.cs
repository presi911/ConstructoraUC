using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConstructoraUC.Common.Entities
{
    public class Block
    {

        public int Id { get; set; }


        [MaxLength(50, ErrorMessage = "The filed {0} must contain less than {1} characteres.")]
        [Required]
        [Display(Name = "Bloque")]
        public String Name { get; set; }
        
        [MaxLength(150, ErrorMessage = "The filed {0} must contain less than {1} characteres.")]
        [Required]
        [Display(Name = "Description")]
        public String Description { get; set; }


        public ICollection<Property> Properties { get; set; }

        [DisplayName("Properties Number")]
        public int PropertiesNumber => Properties == null ? 0 : Properties.Count;

        [JsonIgnore]
        [NotMapped]
        public int IdProject { get; set; }

    }
}
