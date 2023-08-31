using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrainingSystem.Core.Models
{
    public class LookUpCategory : BaseEntity
    {
        [Key]
        public int LookUpCategoryId { get; set; }  //100  ,200   ,300  ,400

        [Required] public int Code { get; set; }    //1        ,2        ,3        ,4

        [Required] public string NameEn { get; set; }  //type   ,topic  ,result   , Status

        [Required] public string NameAr { get; set; }
        public string Description { get; set; }
    }
}
