using Data.Enums;
using Data.Extensions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFSampleConsole.Entities
{
    public class EmployeeTitle
    {
        public EmployeeTitle() { }

        public EmployeeTitle(TitlesEnum titlesEnum)
        {
            Id = (int)titlesEnum;
            Name = titlesEnum.ToString();
            Description = titlesEnum.GetEnumDescription();
        }

        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        //public virtual ICollection<Employee> Employees { get; set; }

        public static implicit operator EmployeeTitle(TitlesEnum titlesEnum) => new EmployeeTitle(titlesEnum);
        public static implicit operator TitlesEnum(EmployeeTitle employeeTitle) => (TitlesEnum)employeeTitle.Id;
    }
}
