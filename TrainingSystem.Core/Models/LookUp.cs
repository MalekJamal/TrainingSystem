using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrainingSystem.Core.Models
{
    public class Lookup : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        public int Code { get; set; }

        [Required] 
        public string NameEn { get; set; }

        [Required] 
        public string NameAr { get; set; }

        public string Description { get; set; }
        [Required] 
        public int LookupCategoryId { get; set; }

        [ForeignKey("LookupCategoryId")]  // Specify the foreign key relationship
        public LookupCategory LookupCategory { get; set; }


    }
}
