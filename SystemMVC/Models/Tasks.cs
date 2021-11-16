using System;
using System.Collections.Generic;

namespace SystemMVC.Models
{
    public partial class Tasks
    {
        public int Id { get; set; }
        public string DeveloperName { get; set; }
        public string ModuleName { get; set; }
        public string ImplentionName { get; set; }

        public string TasKDesciption { get; set; }
        public string EndDate { get; set; }

    }
}
