using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models.Enums
{
    public static class LookupEnum
    {
        public enum enTrainingType
        {
            Work = 1,
            University= 2,
        }

        public enum TrainingTopics
        {
            DotNet = 1,
            BusinessAnalyst = 2,
            QualityControl = 3,
            Infrastructure = 4,
            UI_UX = 5,
            HumanResources=6,
            Finance=7,
            AI=8
        }

        public enum Status
        {
            Active = 1,
            Pending = 2,
            Finished=3
        }
        public enum Result
        {
            Joining_TPS_Team = 1,
            On_Hold = 2,
            Rejected=3,
            Quit=4,
            Eliminated=5
        }

        public enum Trainer
        {
            KhalidSalameh=1,
            LameesHourani=2,
            MariamAl_Sadawi=3,
            MohammadHamad=4,
            MohammadIbdah=5,
            Safaa=6,
            ZakariaLafi=7,
            AhmedSweilem = 8
        }
    }
}
