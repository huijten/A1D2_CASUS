using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class FeedUp 
    {
        FeedUpDAO db = new FeedUpDAO();
        public int Id { get; set; }
        public FeedBase Feed { get; set; }
        public int Priority { get; set; }
        public string Reflection { get; set; }

        public FeedUp() { }

        public FeedUp(int id, FeedBase feed, int priority, string reflection)
        {
            Id = id;
            Feed = feed;
            Priority = priority;
            Reflection = reflection;
        }

        internal List<FeedUp> GetFedup()
        {
            return  db.Read();
        }
    }
}
