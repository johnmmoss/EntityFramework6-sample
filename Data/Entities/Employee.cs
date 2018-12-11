using Data.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFSampleConsole.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        
        public virtual ICollection<Timesheet> Timesheets { get; set; }


        [Required]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
      
        [Required]
        public int EmployeeTitleId { get; set; }
        public virtual EmployeeTitle EmployeeTitle { get; set; }
    }
}
