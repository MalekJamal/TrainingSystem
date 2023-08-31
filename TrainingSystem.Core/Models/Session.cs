using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrainingSystem.Core.Models
{
    public class Session : BaseEntity
    {
        [Key] public int SessionId { get; set; }

      

        [DataType(DataType.Date), Required]
        public DateTime StartDate { get; set; }


        [DataType(DataType.Date), Required]
        public DateTime ExpectedEndDate { get; set; }


        [DataType(DataType.Date)]
        public DateTime ActualEndDate { get; set; }


        [Required] public string Year { get; set; }

        [Required] public string TraineeName { get; set; }

        public LookUp TrainerName { get; set; }

        //  public List<LookUp> TrainingTrainers { get; set; }

        // public LookUp Lookup { get; set; }

        public LookUp Status { get; set; }

        //  public List<LookUp> TrainingStatus { get; set; }


        // public string LookUp { get; set; }
        //public List<LookUp> TrainingResults { get; set; }
        public LookUp Type { get; set; }
        //     public List<LookUp> TrainingTypes { get; set; }


        public LookUp Topic { get; set; }
        //  public List<LookUp> TrainingTopics { get; set; }
        public LookUp Result { get; set; }


        [DataType(DataType.Date)]
        public DateTime FinalPresentationDate { get; set; }

        public double EvaluationScore { get; set; }

        public string Comment { get; set; }
    }
}
