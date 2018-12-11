using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleConsole.Entities
{
        public class Timesheet
        {
            public int Id { get; set; }
            public virtual ICollection<TimesheetEntry> Entries { get; set; }
            public bool IsAuthorised { get; set; }
        }
}
