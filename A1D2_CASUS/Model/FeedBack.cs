using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class FeedBack
    {
        FeedBackDAO db = new FeedBackDAO();
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
        internal void MakeFeedback(FeedBack feeddback)
        {
            db.ApplyFeedback(feeddback);
        }
        internal DataTable Get2d4bAsnmt()
        {
            return db.GetFeedBackDataTable();
        }
    }
}
