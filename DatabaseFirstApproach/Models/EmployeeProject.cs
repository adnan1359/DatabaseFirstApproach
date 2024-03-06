using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstApproach.Models
{
    public class EmployeeProject
    {
        // Junction Table
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } // Reference Navigation Property
        public ICollection<Employee> Employees { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; } // Reference Navigation Property
    }
}
