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
    public partial class FeedbackView : Form
    {
        public FeedbackView()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            var bindingSourceAssignment = new BindingSource();
            Assignment db = new Assignment();
            bindingSourceAssignment.DataSource = db.Get2d4bAsnmt();
            assignmentComboBox.DataSource = bindingSourceAssignment;
            assignmentComboBox.DisplayMember = "Name";
            assignmentComboBox.ValueMember = "Id";
        }

        private void PopulateData(int assignmentId)
        {
            FeedBase db = new FeedBase();
            FeedBase feedBase = db.SearchByAssignment(assignmentId);

            supervisorLbl.Text = feedBase.ApprovedBy.Name;
            deadlineLbl.Text = feedBase.CreationDate.ToString();
            contentLbl.Text = feedBase.Content;
            studentLbl.Text = feedBase.Student.Name;

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {

            PopulateData(Int32.Parse(assignmentComboBox.SelectedValue.ToString()));
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
