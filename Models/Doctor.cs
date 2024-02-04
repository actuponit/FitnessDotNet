using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAuthentication.Models
{
    public class Plan
    {
        public string? Title { get; set; }
        public string Level { get; set; } = "";
        public int? Duration { get; set; }
        public bool? Excercises { get; set; }
    }
}