using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class FeedForward
    {
        public int Id { get; set; }
        public FeedBase Feed { get; set; }
        public string Notes { get; set; }

        public FeedForward() { }
        public FeedForward(int id, FeedBase feed, string notes)
        {
            Id = id;
            Feed = feed;
            Notes = notes;
        }
    }
}
