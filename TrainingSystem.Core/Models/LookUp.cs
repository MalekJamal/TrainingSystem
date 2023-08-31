using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrainingSystem.Core.Models
{
    public class LookUp : BaseEntity
    {
        [Column(name: "Id")]
        [Key] public int Id { get; set; }  //1  /2/  3/ 4

        [Required] public int Code { get; set; }//1

        [Required] public string NameEn { get; set; }//.net  /BA   /BI  /AI

        [Required] public string NameAr { get; set; }

        public string Description { get; set; }

        public LookUpCategory LookUpCategory { get; set; }  //100 : type  /200 topic



    }
}
