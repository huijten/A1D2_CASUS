using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class FeedUp : FeedBase
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
        internal DataTable GetFUPS()
        {
            return db.GetFups();
        }
        internal void Createfup(FeedUp feedup)
        {
            db.CreateFup(feedup);
        }
        internal void EditFeedup(int id, FeedBase Feed, int Priority, string Reflection)
        {
            db.EditFU(id, Feed, Priority,Reflection);
        }
        internal void Delfedup(int id)
        {
            db.DelFU(id);
        }
    }
}
