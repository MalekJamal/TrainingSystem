using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TrainingSystem.Core.Models.Enums
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
            Business_Analyst = 2,
            Quality_Control = 3,
            Infrastructure = 4,
            UI_UX = 5,
            Human_Resources=6,
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
            Khalid_Salameh=1,
            Lamees_Hourani=2,
            Mariam_AlSadawi=3,
            Mohammad_Hamad=4,
            Mohammad_Ibdah=5,
            Safaa=6,
            Zakaria_Lafi=7,
            Ahmed_Sweilem = 8
        }

        public enum Year
        {
            
            Year2023=1,
            Year2024=2,
            Year2025=3,
            Year2026=4,
            Year2027=5,
            Year2028=6,
            Year2029=7,
            Year2030=8,
            Year2031=9,
        }
    }
}
