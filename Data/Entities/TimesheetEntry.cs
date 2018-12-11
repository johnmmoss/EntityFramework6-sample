using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSampleConsole.Entities
{
    public class TimesheetEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeCode TimeCode { get; set; }
        public int TimeSpent { get; set; }
    }
}
