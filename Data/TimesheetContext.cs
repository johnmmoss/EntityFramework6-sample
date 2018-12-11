using EFSampleConsole.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleConsole
{
    public class TimesheetsContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }

        public DbSet<EmployeeTitle> EmployeeTitles { get; set; }
    }
}
