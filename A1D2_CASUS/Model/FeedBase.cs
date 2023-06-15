using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class FeedBase
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Supervisor ApprovedBy { get; set; }
        public Assignment Assignment { get; set; }
        public Student Student { get; set; }
        public string Content { get; set; }

        
    }
}
