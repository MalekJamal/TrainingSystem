using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrainingSystem.Core.Models
{
    public abstract class BaseEntity
    {
        
        public string CreatedBy { get; set; }

        [Column("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        public string ModifyBy { get; set; }

        [Column("ModifyOn")] 
        public DateTime ModifyOn { get; set; }

         
        public bool IsActive { get; set; }
       
        public bool IsDeleted { get; set; }
    }
}
