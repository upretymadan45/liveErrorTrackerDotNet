using System;
using Microsoft.AspNetCore.Identity;

namespace LiveErrorDisplayApp.Models
{
    public class Error{
        public int Id { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
        public string ErrorPath { get; set; }
        public bool IsResolved { get; set; } = false;
        public string ResolvedBy { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime ResolvedOn { get; set; }
    }
}