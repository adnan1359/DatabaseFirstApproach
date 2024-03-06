using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace DatabaseFirstApproach.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public long Salary { get; set; }

        public EmployeeDetails EmployeeDetails { get; set; } // Reference navigation to dependent


        // One To Many Relationship with Manager
        public int ManagerId { get; set; } // Foreign Key
        public Manager Manager { get; set; } // Reference Navigation to manager


        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
