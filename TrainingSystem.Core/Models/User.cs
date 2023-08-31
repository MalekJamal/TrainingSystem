using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSystem.Core.Models
{
    public class User: IdentityUser
    {
        public string FullName { get; set; }
        
    }
}
