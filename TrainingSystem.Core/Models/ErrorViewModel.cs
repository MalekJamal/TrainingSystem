using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSystem.Core.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
