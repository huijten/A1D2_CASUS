using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    public class FeedForward
    {
        FeedForwardDAO db = new FeedForwardDAO();
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

        public void Create(FeedForward feed) 
        {
            db.Create(feed);
        }
        internal void EditFf(int id, FeedBase Feed, string Notes)
        {
            db.EditFF(id, Feed, Notes);
        }
        internal void DeleteFF(int id)
        {
            db.Delfff(id);
        }

        internal DataTable GetDataTables()
        {
            return db.GetDataTables();
        }
    }
}
