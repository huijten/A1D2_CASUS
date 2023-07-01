using A1D2_CASUS.DAO;
using A1D2_CASUS.View;
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
        FeedBase fet = new FeedBase();
        FeedbackView fbv = new FeedbackView();
        FeedBackDAO db = new FeedBackDAO();
        public int Id { get; set; }
        public FeedBase FeedBaseId { get { return FeedBaseId; } set { FeedBaseId = value; } }
        public string Notes { get; set; }

        public FeedBack() { }
        public FeedBack(int id, FeedBase fb, string notes)
        {
            Id = id;
            this.FeedBaseId = fb;
            Notes = notes;
        }
        public FeedBack( FeedBase fed, string notes)
        {
            this.FeedBaseId = fed;
            Notes = notes;
        }

        internal List<FeedBack> ReadFB()
        {
            return db.Read();
        }
        internal DataTable GetFB()
        {
            return db.GetFeedbackFromDatabase();
        }
        internal void Addfedback(FeedBase feedBaseId, String note)
        {
            db.CreateFeedBack(feedBaseId, note);
        }

        
    }
}
