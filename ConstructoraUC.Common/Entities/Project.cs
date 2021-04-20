using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConstructoraUC.Common.Entities
{
    public class Project
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The filed {0} must contain less than {1} characteres.")]
        [Required]
        [Display(Name = "Project")]
        public String Name { get; set; }

        [MaxLength(150, ErrorMessage = "The filed {0} must contain less than {1} characteres.")]
        [Required]
        [Display(Name = "Description")]
        public String Description { get; set; }


        public ICollection<Block> Blocks { get; set; }

        [DisplayName("Blocks Number")]
        public int BlocksNumber => Blocks == null ? 0 : Blocks.Count;

        [JsonIgnore]
        [NotMapped]
        public int IdCity { get; set; }

    }
}
