using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public bool isCompleted { get; set; }

        public Assignment(int id, string name, DateTime deadline, bool isCompleted)
        {
            Id = id;
            Name = name;
            Deadline = deadline;
            this.isCompleted = isCompleted;
        }
    }
}
