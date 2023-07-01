using A1D2_CASUS.DAO;
using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1D2_CASUS.View
{
    public partial class FeedupView : Form
    {
        public FeedupView()
        {
            InitializeComponent();
            fillDGVFeedUp();
        }

        private void FeedupView_Load(object sender, EventArgs e)
        {

        }
        private void fillDGVFeedUp()
        {
            FeedBase fdbase = new FeedBase();
            FeedUp fdup = new FeedUp();
            DGVFU.DataSource = null;
            List<FeedUp> fp = fdup.GetFedup();
            DGVFU.DataSource = fp;
            DGVFU.ResetBindings();

        }

    }
}
