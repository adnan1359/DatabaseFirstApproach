using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstApproach.Models
{
    //[Table("AllManagers")]
    public class Manager
    {
        //[Key]
        public int ManagerId { get; set; }

        //[Column("ManagerFirstName")]
        //[Required]
        //[StringLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[NotMapped]
        //public string Unmapped { get; set; }

        // Since a manager can have multiple employees
        public ICollection<Employee> Employees { get; set; } // Collection Navigation Property
    }
}
