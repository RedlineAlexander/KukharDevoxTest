using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KukharDevoxTest.Models
{
    public class Projects
    {
        public int ProjectsID { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectDateStart { get; set; }

        public DateTime ProjectDateEnd { get; set; }
    }
}
