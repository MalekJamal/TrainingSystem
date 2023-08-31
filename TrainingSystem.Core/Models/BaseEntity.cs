using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrainingSystem.Core.Models
{
    public abstract class BaseEntity
    {
        [Required, Column("CreatedBy"), StringLength(10)]
        public string CreatedBy { get; set; }

        [Required, Column("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [Column("ModifyBy"), StringLength(10)]
        public string ModifyBy { get; set; }

        [Column("ModifyOn")] public DateTime ModifyOn { get; set; }

        [Required] public bool IsActive { get; set; }
        [Required] public bool IsDeleted { get; set; }
    }
}
