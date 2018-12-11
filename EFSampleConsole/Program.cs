using Data.Enums;
using Data.Extensions;
using EFSampleConsole.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            new EFGenerator();
        }
    }


    public class EFGenerator
    {
        public EFGenerator()
        {
            using (var context = new TimesheetsContext())
            {
                try
                {
                    //var dep = new Department() { Id = 3 };            // Creates a new department table, doesnt use exisiting.
                    var dep = context.Departments.First();              // When loaded from context, it works correctly.

                    var title = new EmployeeTitle() { Id = 3 };         // Same pattern as above.
                    
                    var emp = new Employee() {
                        EmployeeTitleId= (int)TitlesEnum.Lady,          // Storing enum directoy as int againest FK property WORKS!!
                        Department = dep,
                        Email = "bill@email.com",
                        Forename = "Bill",
                        Surname = "Mathers" };

                    context.Employees.Add(emp);

                    context.SaveChanges();

                } 
                catch (DbEntityValidationException ex)
                {

                }
            }
        }
    }
}
