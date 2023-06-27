using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class FeedBack
    {
        public int Id { get; set; }
        public FeedBase Feed { get; set; }
        public string Notes { get; set; }

        public FeedBack() { }
        public FeedBack(int id, FeedBase feed, string notes)
        {
            Id = id;
            Feed = feed;
            Notes = notes;
        }
    }
}
